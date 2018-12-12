#!/bin/bash
#
# Script : color_converter.sh
# convert color code by asking the user the type of code he has and the values if he hasn't gave it in parameter when he called the script.
# Ryser tom T.IS-E1b
# 10.12.2018 v3

#Constants
declare PERCENT=p
declare ABSOLUTE=a
declare CLI=cli
declare INTERACTIVE=interactive
declare MAX_PERCENT=100
declare MAX_ABSOLUTE=255
declare MIN_NUMBER=0

#Variables
declare TYPE_COLOR_VAL
declare RED
declare GREEN
declare BLUE
#Store the way the script as been called
declare TYPE_CALL

#Error messages
declare SYNTAX="Please use this syntax : ./color_converter_v3.sh {-p | -a} red green blue"
declare PERCENT_NOTINRANGE="Please use this syntax : ./color_converter_v2.sh -p red($MIN_NUMBER-$MAX_PERCENT) green($MIN_NUMBER-$MAX_PERCENT) blue($MIN_NUMBER-$MAX_PERCENT)"
declare ABSOLUTE_NOTINRANGE="Please use this syntax : ./color_converter_v2.sh -a red($MIN_NUMBER-$MAX_ABSOLUTE) green($MIN_NUMBER-$MAX_ABSOLUTE) blue($MIN_NUMBER-$MAX_ABSOLUTE)"
declare REGEX='^[0-9]+$'

#Functions
function ASK_COLOR {
    local MAX=$1
    local COLOR=$2
    local COLOR_CODE=$2
    until [[ "$COLOR_CODE" =~ $REGEX && "$COLOR_CODE" -ge "$MIN_NUMBER" && "$COLOR_CODE" -le "$MAX" ]]; do
        read -p "how much $COLOR ($MIN_NUMBER...$MAX) ? [0] : " COLOR_CODE
        #Default value to 0
        COLOR_CODE="${COLOR_CODE:-0}"
    done
    echo "$COLOR_CODE"
}

function CONVERT_PERCENT_TO_ABSOLUTE {
    local COLOR=$1
    let "COLOR = (($COLOR * $MAX_ABSOLUTE) / $MAX_PERCENT)"
    #Convert the float number as string 
    echo $(printf "%.0f" $COLOR)
}

function CHECK_NUMBER_AND_IN_RANGE {
    #function param init.
    TYPE_COLOR_VAL=$1
    RED=$2
    GREEN=$3
    BLUE=$4
    SYNTAX_MESSAGE=$5

    #check type of color value
    if [[ "$TYPE_COLOR_VAL" = $PERCENT ]]; then
        MAX=$MAX_PERCENT
    elif [[ "$TYPE_COLOR_VAL" = $ABSOLUTE ]]; then
        MAX=$MAX_ABSOLUTE
    fi
    #check value and transform if necessary (percent to absolute)
    if [[ "$RED" =~ $REGEX && "$GREEN" =~ $REGEX && "$BLUE" =~ $REGEX ]]; then
        if [[ ("$RED" -ge "$MIN_NUMBER" && "$RED" -le "$MAX") && ("$GREEN" -ge "$MIN_NUMBER" && "$GREEN" -le "$MAX") && ("$BLUE" -ge "$MIN_NUMBER" && "$BLUE" -le "$MAX") ]]; then
            if [[ "$TYPE_COLOR_VAL" = $PERCENT ]]; then
                RED=$(CONVERT_PERCENT_TO_ABSOLUTE $RED)
                GREEN=$(CONVERT_PERCENT_TO_ABSOLUTE $GREEN)
                BLUE=$(CONVERT_PERCENT_TO_ABSOLUTE $BLUE)
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
# ($#) is the count of parameters
if [ $# -ne 4 ] && [ $# -gt 0 ]; then
    echo $SYNTAX
    exit -1
elif [ $# -eq 0 ]; then
    TYPE_CALL=$INTERACTIVE
    until [ "$TYPE_COLOR_VAL" = "$ABSOLUTE" ] || [ "$TYPE_COLOR_VAL" = "$PERCENT" ]; do
        read -p "percent/absolute? [p] : " TYPE_COLOR_VAL
        if [ -z "$TYPE_COLOR_VAL" ]; then
            TYPE_COLOR_VAL="p"
        fi
    done
else
    TYPE_CALL=$CLI
    RED=$2
    GREEN=$3
    BLUE=$4
    if [[ "$1" = "-$PERCENT" ]]; then
        TYPE_COLOR_VAL=$PERCENT
    elif [[ "$1" = "-$ABSOLUTE" ]]; then
        TYPE_COLOR_VAL=$ABSOLUTE
    else
        echo $SYNTAX
        exit -1
    fi
fi



#Ask colors codes and convert them to hexadecimal
if [ "$TYPE_COLOR_VAL" = $PERCENT ]; then
    if [[ "$TYPE_CALL" = "$INTERACTIVE" ]]; then
        RED=$(ASK_COLOR $MAX_PERCENT $RED "red")
        GREEN=$(ASK_COLOR $MAX_PERCENT $GREEN "green")
        BLUE=$(ASK_COLOR $MAX_PERCENT $BLUE "blue")

        RED=$(CONVERT_PERCENT_TO_ABSOLUTE $RED)
        GREEN=$(CONVERT_PERCENT_TO_ABSOLUTE $GREEN)
        BLUE=$(CONVERT_PERCENT_TO_ABSOLUTE $BLUE)
    else
        CHECK_NUMBER_AND_IN_RANGE p $RED $GREEN $BLUE "$PERCENT_NOTINRANGE"
    fi
else
    if [[ "$TYPE_CALL" = "$INTERACTIVE" ]]; then
        RED=$(ASK_COLOR $MAX_ABSOLUTE $RED "red")
        GREEN=$(ASK_COLOR $MAX_ABSOLUTE $GREEN "green")
        BLUE=$(ASK_COLOR $MAX_ABSOLUTE $BLUE "blue")
    else
        CHECK_NUMBER_AND_IN_RANGE a $RED $GREEN $BLUE "$ABSOLUTE_NOTINRANGE"
    fi
    
fi

if [[ "$TYPE_CALL" = "$INTERACTIVE" ]]; then
    printf "%02x%02x%02x\n" $RED $GREEN $BLUE
fi;

exit 0