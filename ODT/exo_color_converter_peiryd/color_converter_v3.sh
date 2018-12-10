#!/bin/bash
#
# Script : color_converter.sh
# convert color
# Ryser tom T.IS-E1b
# 04.12.2018 v3

#Constants
declare PERCENT=p
declare ABSOLUTE=a
declare CLI=cli
declare INTERACTIVE=interactive
declare PERCENT_MAX=100
declare ABSOLUTE_MAX=255
declare NUMBER_MIN=0
#Variables
declare TYPE
#Store if we use the interactive TYPE or command line one
declare INTERACTIVE_OR_CLI
#I set the colors codes to -1 cause for the read sets the value to 0 by default and it breaks the until loop
declare RED=-1
declare GREEN=-1
declare BLUE=-1
#Error messages
declare SYNTAX="Please use this syntax : ./color_converter_v3.sh {-p | -a} red green blue"
declare PERCENT_NOTINRANGE="Please use this syntax : ./color_converter_v2.sh -p red($NUMBER_MIN-$PERCENT_MAX) green($NUMBER_MIN-$PERCENT_MAX) blue($NUMBER_MIN-$PERCENT_MAX)"
declare ABSOLUTE_NOTINRANGE="Please use this syntax : ./color_converter_v2.sh -a red($NUMBER_MIN-$ABSOLUTE_MAX) green($NUMBER_MIN-$ABSOLUTE_MAX) blue($NUMBER_MIN-$ABSOLUTE_MAX)"
declare REGEX='^[0-9]+$'
#Functions
#Syntax : ASK_COLOR MAX COLOR {red/green/blue}
function ASK_COLOR {
    local MAX=$1
    local COLOR=$2
    local COLOR=$3
    until [[ "$COLOR" =~ $REGEX && "$COLOR" -ge "$NUMBER_MIN" && "$COLOR" -le "$MAX" ]]; do
        read -p "how much $COLOR ($NUMBER_MIN...$MAX) ? [0] : " COLOR
        #Default value to 0
        COLOR="${COLOR:-0}"
    done
    echo "$COLOR"
}
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

# $# gives us the number of args
if [ $# -ne 4 ] && [ $# -gt 0 ]; then
    echo $SYNTAX
    exit -1
elif [ $# -eq 0 ]; then
    INTERACTIVE_OR_CLI=$INTERACTIVE
    #We ask the user to enter the TYPE he wants until he enters "a" or "p". 
    #if he just press enter then the TYPE is set to "p" by default
    until [ "$TYPE" = "$ABSOLUTE" ] || [ "$TYPE" = "$PERCENT" ]; do
        read -p "percent/absolute? [p] : " TYPE
        if [ -z "$TYPE" ]; then
            TYPE="p"
        fi
    done
else
    # $1-9 contains parameters
    INTERACTIVE_OR_CLI=$CLI
    RED=$2
    GREEN=$3
    BLUE=$4
    if [[ "$1" = "-$PERCENT" ]]; then
        TYPE=$PERCENT
    elif [[ "$1" = "-$ABSOLUTE" ]]; then
        TYPE=$ABSOLUTE
    else
        echo $SYNTAX
        exit -1
    fi
fi


#todo functions refactoring
#We ask the user to enter colors codes and convert them to hexadecimal string
if [ "$TYPE" = $PERCENT ]; then
    #We either ask the user to enter values until they are in range and numbers or we just check the values from the args
    if [[ "$INTERACTIVE_OR_CLI" = "$INTERACTIVE" ]]; then
        RED=$(ASK_COLOR $PERCENT_MAX $RED "red")
        GREEN=$(ASK_COLOR $PERCENT_MAX $GREEN "green")
        BLUE=$(ASK_COLOR $PERCENT_MAX $BLUE "blue")

        RED=$(CONVERT_PERCENT_TO_ABSOLUTE $RED)
        GREEN=$(CONVERT_PERCENT_TO_ABSOLUTE $GREEN)
        BLUE=$(CONVERT_PERCENT_TO_ABSOLUTE $BLUE)
    else
        CHECK_NUMBER_AND_IN_RANGE p $RED $GREEN $BLUE "$PERCENT_NOTINRANGE"
    fi
else
    if [[ "$INTERACTIVE_OR_CLI" = "$INTERACTIVE" ]]; then
        RED=$(ASK_COLOR $ABSOLUTE_MAX $RED "red")
        GREEN=$(ASK_COLOR $ABSOLUTE_MAX $GREEN "green")
        BLUE=$(ASK_COLOR $ABSOLUTE_MAX $BLUE "blue")
    else
        CHECK_NUMBER_AND_IN_RANGE a $RED $GREEN $BLUE "$ABSOLUTE_NOTINRANGE"
    fi
    
fi

if [[ "$INTERACTIVE_OR_CLI" = "$INTERACTIVE" ]]; then
    #Display the converted string to hexadecimal on this format 000000 so it is always a 6 characters string
    printf "%02x%02x%02x\n" $RED $GREEN $BLUE
fi;

exit 0