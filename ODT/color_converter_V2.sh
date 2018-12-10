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

#Error messages
declare SYNTAX="Please use this syntax : ./color_converter_V2.sh {-p | -a} red green blue"
declare PERCENT_NOTINRANGE="Please use this syntax : ./color_converter_V2.sh {-p | -a} red($MIN_NUMBER-$MAX_PERCENT) green($MIN_NUMBER-$MAX_PERCENT) blue($MIN_NUMBER-$MAX_PERCENT)"
declare ABSOLUTE_NOTINRANGE="Please use this syntax : ./color_converter_V2.sh {-p | -a} red($MIN_NUMBER-$MAX_ABSOLUTE) green($MIN_NUMBER-$MAX_ABSOLUTE) blue($MIN_NUMBER-$MAX_ABSOLUTE)"
declare REGEX='^[0-9]+$'

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
#Syntax : CHECK_NUMBER_AND_IN_RANGE {p/a} red green blue syntax_message
function CHECK_NUMBER_AND_IN_RANGE {
    MODE=$1
    RED=$2
    GREEN=$3
    BLUE=$4
    SYNTAX_MESSAGE=$5
    if [[ "$TYPE" = $PERCENT ]]; then
        MAX=$PERCENT_MAX
    elif [[ "$TYPE" = $ABSOLUTE ]]; then
        MAX=$ABSOLUTE_MAX
    fi
    if [[ "$RED" =~ $REGEX && "$GREEN" =~ $REGEX && "$BLUE" =~ $REGEX ]]; then
        if [[ ("$RED" -ge "$MIN_NUMBER" && "$RED" -le "$MAX") && ("$GREEN" -ge "$MIN_NUMBER" && "$GREEN" -le "$MAX") && ("$BLUE" -ge "$MIN_NUMBER" && "$BLUE" -le "$MAX") ]]; then
            if [[ "$TYPE" = $PERCENT ]]; then
                RED=$(CONVERT_PERCENT_TO_ABSOLUTE $RED)
                GREEN=$(CONVERT_PERCENT_TO_ABSOLUTE $GREEN)
                BLUE=$(CONVERT_PERCENT_TO_ABSOLUTE $BLUE)
                echo $RED $GREEN $BLUE cnair

            fi
            #Display the converted string to hexadecimal on this format 000000 so it is always a 6 characters string
            printf "%02x%02x%02x\n" $RED $GREEN $BLUE
        else
            echo $SYNTAX_MESSAGE
        fi
    else
        echo $SYNTAX_MESSAGE
    fi
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
