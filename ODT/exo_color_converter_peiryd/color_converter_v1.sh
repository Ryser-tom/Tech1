#!/bin/bash
#
# Script : color_converter.sh
# convert color
# Ryser tom T.IS-E1b
# 09.12.2018 v1


#Constants
declare PERCENT=p
declare ABSOLUTE=a
declare PERCENT_MAX=100
declare ABSOLUTE_MAX=255
declare NUMBER_MIN=0

#Variables
declare TYPE
declare RED
declare GREEN
declare BLUE

#functions
#Syntax : ASK_COLOR MAX COLOR
function ASK_COLOR {
    local MAX=$1
    local COLOR=$2
    local COLOR=$3
    # a number on one or multiples occurences
    local REGEX='^[0-9]+$'
    #We prompt the question to the user unless we got a number in the correct range
    until [[ "$COLOR" =~ $REGEX && "$COLOR" -ge "$NUMBER_MIN" && "$COLOR" -le "$MAX" ]]; do
        read -p "how much $COLOR ($NUMBER_MIN...$MAX) ? [$NUMBER_MIN] : " COLOR
        #Default value to 0
        COLOR="${COLOR:-0}"
    done
    echo "$COLOR"
}
#Syntax : CONVERT_PERCENT_TO_ABSOLUTE COLOR
function CONVERT_PERCENT_TO_ABSOLUTE {
    local COLOR=$1
    #Convert the percent to the absolute value using the bc command (bc = Bash/Calculs)
    #Send the string to the bc command to be executed. Store the result of the bc in the RED variable as a string
    #COLOR=$(bc<<<"scale=1;(($ABSOLUTE_MAX*$COLOR)/$PERCENT_MAX)")
    let "COLOR = (($COLOR * $ABSOLUTE_MAX) / $PERCENT_MAX)"
    #Convert the float number stored as a string to the next up integer
    echo $(printf "%.0f" $COLOR)
}
#We ask the user to enter the TYPE he wants until he enters "a" or "p". 
#if he just press enter then the TYPE is set to "p" by default
until [[ "$TYPE" = "$ABSOLUTE" || "$TYPE" = "$PERCENT" ]]; do
    read -p "percent/absolute? [$PERCENT] : " TYPE
    if [[ -z "$TYPE" ]]; then
        TYPE="p"
    fi
done

#todo functions refactoring
#Ask the user to enter colors codes and convert them to hexadecimal string
if [[ "$TYPE" = $PERCENT ]]; then
    #We loop until we have the number in range as wanted > Could use while too
    RED=$(ASK_COLOR $PERCENT_MAX RED "red")
    GREEN=$(ASK_COLOR $PERCENT_MAX GREEN "green")
    BLUE=$(ASK_COLOR $PERCENT_MAX BLUE "blue")

    RED=$(CONVERT_PERCENT_TO_ABSOLUTE $RED)
    GREEN=$(CONVERT_PERCENT_TO_ABSOLUTE $GREEN)
    BLUE=$(CONVERT_PERCENT_TO_ABSOLUTE $BLUE)
else
    RED=$(ASK_COLOR $ABSOLUTE_MAX RED "red")
    GREEN=$(ASK_COLOR $ABSOLUTE_MAX GREEN "green")
    BLUE=$(ASK_COLOR $ABSOLUTE_MAX BLUE "blue")
fi

printf "%02x%02x%02x\n" $RED $GREEN $BLUE

exit 0