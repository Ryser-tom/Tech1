#!/bin/bash
#
# Script : color_converter.sh
# convert color code by asking the user the type of code he has and the values.
# Ryser tom T.IS-E1b
# 04.12.2018 v1

#Constants

#Variables
declare FILE_TO_MODIFY
declare FILE_TO_SAVE
declare RANGE_X
declare RANGE_Y
declare TEXT


#functions

function MODIFY_IMAGE {
     convert $FILE_TO_MODIFY -gravity North -pointsize 30 -annotate +0+100 $TEXT $FILE_TO_SAVE
}

#start of script
FILE_TO_MODIFY="img/index.jpg"
FILE_TO_SAVE="img/tmp.jpg"
TEXT="SALUT"
MODIFY_IMAGE
