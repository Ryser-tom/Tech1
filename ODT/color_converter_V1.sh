#!/bin/bash
#
# Script : color_converter.sh
# convert color
# Ryser tom T.IS-E1b
# 04.12.2018

shopt -s -o nounset

declare PERCENT=p
declare ABSOLUTE=a
declare MAX_ABSOLUTE=255
declare MAX_PERCENT=100
declare MIN_NUMBER=0

declare TYPE=default
declare RED
declare GREEN
declare BLUE

#Syntax : ASK_COLOR MAX COLOR {red/green/blue}
function ASK_COLOR {
    local MAX=$1
    local COLOR=$2
    local COLOR=$3
    # a number on one or multiples occurences
    local REGEX='^[0-9]+$'
    #We prompt the question to the user unless we got a number in the correct range
    until [[ "$COLOR" =~ $REGEX && "$COLOR" -ge "$MIN_NUMBER" && "$COLOR" -le "$MAX" ]]; do
        read -p "how much $COLOR ($MIN_NUMBER...$MAX) ? [0] : " COLOR
        #Default value to 0
        COLOR="${COLOR:-0}"
    done
    echo "$COLOR"
}





read -p "Percent / absolute ? ($PERCENT/$ABSOLUTE)" TYPE
echo
if [ "$TYPE" = "$PERCENT" ]
then
    RED=$(ASK_COLOR $MAX_PERCENT RED "red")
    GREEN=$(ASK_COLOR $MAX_PERCENT GREEN "green")
    BLUE=$(ASK_COLOR $MAX_PERCENT BLUE "blue")

    let "RED = ((RED * $MAX_ABSOLUTE) / $MAX_PERCENT)"
    let "GREEN = ((GREEN * $MAX_ABSOLUTE) / $MAX_PERCENT)"
    let "BLUE = ((BLUE * $MAX_ABSOLUTE) / $MAX_PERCENT)"
fi
if [ "$TYPE" = "$ABSOLUTE" ]
then
    RED=$(ASK_COLOR $MAX_ABSOLUTE RED "red")
    GREEN=$(ASK_COLOR $MAX_ABSOLUTE GREEN "green")
    BLUE=$(ASK_COLOR $MAX_ABSOLUTE BLUE "blue")
fi
if [ "$TYPE" != "$PERCENT" ] && [ "$TYPE" != "$ABSOLUTE" ]
then
    printf "You had to choose between 'p' and 'a'.\n "
    exit
fi

printf "%02x%02x%02x\n" $RED $GREEN $BLUE
