#!/bin/bash
#
# Script : color_converter.sh
# convert color
# Ryser tom T.IS-E1b
# 04.12.2018 v2

#Constants
declare PERCENT=p
declare ABSOLUTE=a
declare PERCENT_MAX=100
declare ABSOLUTE_MAX=255
declare NUMBER_MIN=0
#Variables
declare TYPE
#I set the colors codes to -1 cause for the read sets the value to 0 by default and it breaks the until loop
declare RED
declare GREEN
declare BLUE
#Error messages
declare SYNTAX="Please use this syntax : ./color_converter_v2.sh {-p | -a} red green blue"
declare PERCENT_NOTINRANGE="Please use this syntax : ./color_converter_v2.sh -p red($NUMBER_MIN-$PERCENT_MAX) green($NUMBER_MIN-$PERCENT_MAX) blue($NUMBER_MIN-$PERCENT_MAX)"
declare ABSOLUTE_NOTINRANGE="Please use this syntax : ./color_converter_v2.sh -a red($NUMBER_MIN-$ABSOLUTE_MAX) green($NUMBER_MIN-$ABSOLUTE_MAX) blue($NUMBER_MIN-$ABSOLUTE_MAX)"
declare REGEX='^[0-9]+$'
#Functions

#Syntax : CONVERT_PERCENT_TO_ABSOLUTE COLOR
function CONVERT_PERCENT_TO_ABSOLUTE {
    local COLOR=$1
    let "COLOR = (($COLOR * $ABSOLUTE_MAX) / $PERCENT_MAX)"
    #Convert the float number stored as a string to the next up integer
    echo $(printf "%.0f" $COLOR)
}
#Syntax : CHECK_NUMBER_AND_IN_RANGE {p/a} red green blue syntax_message
function CHECK_NUMBER_AND_IN_RANGE {
    TYPE=$1
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
        if [[ ("$RED" -ge "$NUMBER_MIN" && "$RED" -le "$MAX") && ("$GREEN" -ge "$NUMBER_MIN" && "$GREEN" -le "$MAX") && ("$BLUE" -ge "$NUMBER_MIN" && "$BLUE" -le "$MAX") ]]; then
            if [[ "$TYPE" = $PERCENT ]]; then
                RED=$(CONVERT_PERCENT_TO_ABSOLUTE $RED)
                GREEN=$(CONVERT_PERCENT_TO_ABSOLUTE $GREEN)
                BLUE=$(CONVERT_PERCENT_TO_ABSOLUTE $BLUE)
                echo $RED $GREEN $BLUE cnair

            fi
            printf "%02x%02x%02x\n" $RED $GREEN $BLUE
        else
            echo $SYNTAX_MESSAGE
        fi
    else
        echo $SYNTAX_MESSAGE
    fi
}

#Check that all parameters are correct to not convert random values
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

#We ask the user to enter colors codes and convert them to hexadecimal string
if [[ "$TYPE" = $PERCENT ]]; then
    CHECK_NUMBER_AND_IN_RANGE p $RED $GREEN $BLUE "$PERCENT_NOTINRANGE"
elif [[ "$TYPE" = $ABSOLUTE ]]; then
    CHECK_NUMBER_AND_IN_RANGE a $RED $GREEN $BLUE "$ABSOLUTE_NOTINRANGE"
else
    exit -1
fi

exit 0