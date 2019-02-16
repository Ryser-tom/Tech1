#!/bin/bash
# $Id: unit_test_maze.sh 2957 2011-11-20 16:21:43Z marechal $
# unit tests for preprocessor assignment
if test $# -eq 0 ; then
echo "Usage : $0 C_source_filename"
exit
fi
echo "Source : $1.c"
echo "without size value"
gcc -o $1 $1.c
./$1
echo "--------------------------------------"
echo "with -2"
gcc -DMAZE_REQ_SIZE=-2 -o $1 $1.c
./$1
echo "--------------------------------------"
echo "with -1"
gcc -DMAZE_REQ_SIZE=-1 -o $1 $1.c
./$1
echo "--------------------------------------"
echo "with 0"
gcc -DMAZE_REQ_SIZE=0 -o $1 $1.c
./$1
echo "--------------------------------------"
echo "with 1"
gcc -DMAZE_REQ_SIZE=1 -o $1 $1.c
./$1
echo "--------------------------------------"
echo "with 2"
gcc -DMAZE_REQ_SIZE=2 -o $1 $1.c
./$1
echo "--------------------------------------"
echo "with 10"
gcc -DMAZE_REQ_SIZE=10 -o $1 $1.c
./$1
echo "--------------------------------------"
echo "with 11"
gcc -DMAZE_REQ_SIZE=11 -o $1 $1.c
./$1
echo "--------------------------------------"
echo "with 98"
gcc -DMAZE_REQ_SIZE=98 -o $1 $1.c
./$1
echo "--------------------------------------"
echo "with 99"
gcc -DMAZE_REQ_SIZE=99 -o $1 $1.c
./$1
echo "--------------------------------------"
echo "with 100"
gcc -DMAZE_REQ_SIZE=100 -o $1 $1.c
./$1
echo "--------------------------------------"
echo "with 101"
gcc -DMAZE_REQ_SIZE=101 -o $1 $1.c
./$1
echo "--------------------------------------"
echo "with 102"
gcc -DMAZE_REQ_SIZE=102 -o $1 $1.c
./$1
echo "--------------------------------------"
echo "with 455"
gcc -DMAZE_REQ_SIZE=455 -o $1 $1.c
./$1
echo "--------------------------------------"
echo "with 456"
gcc -DMAZE_REQ_SIZE=456 -o $1 $1.c
./$1
