#!/usr/bin/env bash

SRC_ROOT=$(readlink -f $(dirname ${BASH_SOURCE[0]}))
NUPKG_DIR="${SRC_ROOT}/nupkg"

COLOR_RESET='\033[0;39m'
COLOR_RED='\033[0;91m'

usage() {
  printf "$0 usage:" && grep " .)\ #" "$0\n"
  exit 0
}

print_var() {
  [ "$#" -ne 1 ] && exit 101; # Exit if not enough arguments are provided
  printf "$1: '${!1}'\n"
}

test_var() {
  [ "$#" -ne 2 ] && exit 102;
  if [ -z "${!1}" ]; then
    printf "The ${COLOR_RED}\$$1${COLOR_RESET} environment variable was not set. The package was not published.\n"
    exit $2
  fi
}

# Exit if the source root is not a directory.
[ ! -d "${SRC_ROOT}" ] && exit 100;

# Parse options
while getopts "vdh" opt; do
  case ${opt} in
    v) # Verbose output
      VERBOSE=1
      print_var "SRC_ROOT"
      print_var "NUPKG_DIR"
      ;;
    h | *) usage;;
  esac
done

if [ -d "${NUPKG_DIR}" ]; then
  # Remove leftover packages
  rm_args=( "-rf" )
  [ ! -z "${VERBOSE}" ] && rm_args+=("-v")
  
  rm ${rm_args[@]} "${NUPKG_DIR}"
fi

# Package libraries
for project in */*.csproj; do
  dotnet pack -c Release "${project}"
done

test_var "NUGET_KEY" 1
test_var "NUGET_SRC" 2

for pkg in "${NUPKG_DIR}/*.nupkg"; do
  # Push libraries to nuget source
  [ ! -z "${VERBOSE}" ] && echo $pkg
  dotnet nuget push -k "${NUGET_KEY}" -s "${NUGET_SRC}" "$pkg"
done