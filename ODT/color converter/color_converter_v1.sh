#!/bin/bash
#
# Script : color_converter.sh
# convert color code by asking the user the type of code he has and the values.
# Ryser tom T.IS-E1b
# 04.12.2018 v1

#Constants
declare PERCENT=p
declare ABSOLUTE=a
declare MAX_PERCENT=100
declare MAX_ABSOLUTE=255
declare MIN_NUMBER=0

#Variables
declare TYPE
declare RED
declare GREEN
declare BLUE

#functions
function ASK_COLOR {
    local MAX=$1
    local COLOR=$2
    local COLOR=$3
    # a number on one or multiples occurences
    local REGEX='^[0-9]+$'
    #We prompt the question to the user unless we got a number in the correct range
    until [[ "$COLOR" =~ $REGEX && "$COLOR" -ge "$MIN_NUMBER" && "$COLOR" -le "$MAX" ]]; do
        read -p "how much $COLOR ($MIN_NUMBER...$MAX) ? [$MIN_NUMBER] : " COLOR
        #Default value to 0
        COLOR="${COLOR:-0}"
    done
    echo "$COLOR"
}

function CONVERT_PERCENT_TO_ABSOLUTE {
    local COLOR=$1
    let "COLOR = (($COLOR * $MAX_ABSOLUTE) / $MAX_PERCENT)"
    #Convert the float number as string 
    echo $(printf "%.0f" $COLOR)
}

#start of program

until [[ "$TYPE" = "$ABSOLUTE" || "$TYPE" = "$PERCENT" ]]; do
    read -p "percent/absolute? [$PERCENT] : " TYPE
    if [[ -z "$TYPE" ]]; then
        TYPE="p"
    fi
done

#Ask colors codes and convert them to hexadecimal
if [[ "$TYPE" = $PERCENT ]]; then
    RED=$(ASK_COLOR $MAX_PERCENT RED "red")
    GREEN=$(ASK_COLOR $MAX_PERCENT GREEN "green")
    BLUE=$(ASK_COLOR $MAX_PERCENT BLUE "blue")

    RED=$(CONVERT_PERCENT_TO_ABSOLUTE $RED)
    GREEN=$(CONVERT_PERCENT_TO_ABSOLUTE $GREEN)
    BLUE=$(CONVERT_PERCENT_TO_ABSOLUTE $BLUE)
else
    RED=$(ASK_COLOR $MAX_ABSOLUTE RED "red")
    GREEN=$(ASK_COLOR $MAX_ABSOLUTE GREEN "green")
    BLUE=$(ASK_COLOR $MAX_ABSOLUTE BLUE "blue")
fi

printf "%02x%02x%02x\n" $RED $GREEN $BLUE

exit 0