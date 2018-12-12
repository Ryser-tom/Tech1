#!/bin/bash
#
# Script : color_converter.sh
# convert color code with type of code and red, green, blue color code in parameter when the script is called.  
# Ryser tom T.IS-E1b
# 09.12.2018 v2

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

#Error messages
declare SYNTAX="Please use this syntax : ./color_converter_v2.sh {-p | -a} red green blue"
declare PERCENT_NOTINRANGE="Please use this syntax : ./color_converter_v2.sh -p red($MIN_NUMBER-$MAX_PERCENT) green($MIN_NUMBER-$MAX_PERCENT) blue($MIN_NUMBER-$MAX_PERCENT)"
declare ABSOLUTE_NOTINRANGE="Please use this syntax : ./color_converter_v2.sh -a red($MIN_NUMBER-$MAX_ABSOLUTE) green($MIN_NUMBER-$MAX_ABSOLUTE) blue($MIN_NUMBER-$MAX_ABSOLUTE)"
declare REGEX='^[0-9]+$'

#Functions
function PERCENT_TO_ABSOLUTE {
    local COLOR=$1
    let "COLOR = (($COLOR * $MAX_ABSOLUTE) / $MAX_PERCENT)"
    #Convert the float number stored as a string to the next up integer
    echo $(printf "%.0f" $COLOR)
}

function CHECK_NUMBER_AND_RANGE {
    #function param init.
    TYPE=$1
    RED=$2
    GREEN=$3
    BLUE=$4
    SYNTAX_MESSAGE=$5

    #check type of value
    if [[ "$TYPE" = $PERCENT ]]; then
        MAX=$MAX_PERCENT
    elif [[ "$TYPE" = $ABSOLUTE ]]; then
        MAX=$MAX_ABSOLUTE
    fi
    #check value and transform if necessary (percent to absolute)
    if [[ "$RED" =~ $REGEX && "$GREEN" =~ $REGEX && "$BLUE" =~ $REGEX ]]; then
        if [[ ("$RED" -ge "$MIN_NUMBER" && "$RED" -le "$MAX") && ("$GREEN" -ge "$MIN_NUMBER" && "$GREEN" -le "$MAX") && ("$BLUE" -ge "$MIN_NUMBER" && "$BLUE" -le "$MAX") ]]; then
            if [[ "$TYPE" = $PERCENT ]]; then
                RED=$(PERCENT_TO_ABSOLUTE $RED)
                GREEN=$(PERCENT_TO_ABSOLUTE $GREEN)
                BLUE=$(PERCENT_TO_ABSOLUTE $BLUE)

            fi
            printf "%02x%02x%02x\n" $RED $GREEN $BLUE
        else
            echo $SYNTAX_MESSAGE
        fi
    else
        echo $SYNTAX_MESSAGE
    fi
}

#start of program

#Check parameters quantities and values
if [[ $# -lt 4 ]]; then
    echo $SYNTAX
else
    RED=$2
    GREEN=$3
    BLUE=$4
    if [[ "$1" = "-$PERCENT" ]]; then
        TYPE=$PERCENT
    elif [[ "$1" = "-$ABSOLUTE" ]]; then
        TYPE=$ABSOLUTE
    else
        echo $SYNTAX
    fi
fi

#Ask the colors codes and convert them to hexadecimal
if [[ "$TYPE" = $PERCENT ]]; then
    CHECK_NUMBER_AND_RANGE p $RED $GREEN $BLUE "$PERCENT_NOTINRANGE"
elif [[ "$TYPE" = $ABSOLUTE ]]; then
    CHECK_NUMBER_AND_RANGE a $RED $GREEN $BLUE "$ABSOLUTE_NOTINRANGE"
else
    exit -1
fi
exit 0