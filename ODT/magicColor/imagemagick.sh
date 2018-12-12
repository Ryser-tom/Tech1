#!/bin/bash
#
# Script : F_toC.sh
# Farenheit to Celsius temperature conversion
# Ryser tom T.IS-E1b
# 04.12.2018

shopt -s -o nounset

declare MAX_PERCENT=100
declare AXE_X=X
declare AXE_Y=Y
declare COLOR=red
declare SIZE=20
declare DENSITY=90
declare DATETIME=$(date +"%T");
declare MARGIN_WIDTH

declare target
declare TEXT
declare POSITION_IN_PERCENT_X=1
declare POSITION_IN_PERCENT_Y=1


declare SYNTAX="Please use this syntax : /tag_images.sh {target folder} {text to add in image}"

function MODIFY_IMAGE {
    #using gravity to choose where we are
    #convert $1 -pointsize $SIZE -gravity NorthWest -fill $COLOR -annotate +30+10 "$TEXT" $target/$1
    
    #using pixels to choose the position of the text
    convert $1 -density $DENSITY -pointsize $SIZE  -fill $COLOR -annotate +$POSITION_TEXT_X+$POSITION_TEXT_Y "$TEXT" $target/$1
    convert $target/$1 -pointsize $SIZE -gravity SouthWest -annotate +30+10 "$DATETIME" $target/$1

}

function CALCULATE_POSITION_FROM_PERCENT {
    local POSITION=$1
    local SIZE_IMG=$2
    local DIRECTION=$3
    local MID_OF_MAX_PERCENT
    let "MID_OF_MAX_PERCENT = ($MAX_PERCENT/2)"


    if [[ "$DIRECTION" = "$AXE_X" && $POSITION -gt $MID_OF_MAX_PERCENT ]] 
    then
        let "SIZE_IMG = ($SIZE_IMG - $MARGIN_WIDTH)"
    else
        let "SIZE_IMG = ($SIZE_IMG + $MARGIN_WIDTH)"
    fi

    let "POSITION = (($POSITION * $SIZE_IMG) / $MAX_PERCENT)"
    echo "$POSITION"
}

if [[ $# -lt 2 ]]; then
    echo $SYNTAX
    exit -1
else
    target=$1
    TEXT=$2
    MARGIN_WIDTH=${#TEXT}

    [[ -d $target ]] || mkdir $target

    for file in *.jpg; 
    do 

        declare IMAGE_HEIGHT=`convert $file -format '%h' info:` 
        declare IMAGE_WIDTH=`convert $file -format '%w' info:`

        POSITION_TEXT_X=$(CALCULATE_POSITION_FROM_PERCENT $POSITION_IN_PERCENT_X $IMAGE_WIDTH "$AXE_X")
        POSITION_TEXT_Y=$(CALCULATE_POSITION_FROM_PERCENT $POSITION_IN_PERCENT_Y $IMAGE_HEIGHT "$AXE_Y")
        MODIFY_IMAGE $file
        echo "$file done : $POSITION_TEXT_X, $POSITION_TEXT_Y image x $IMAGE_WIDTH, y $IMAGE_HEIGHT"
    done
fi


function TMP {
    local POSITION=$1
    local MAX_VALUE=$2
    local DIRECTION=$3
    local SIZE_TEXT=${#TEXT}
    local MID_OF_MAX_PERCENT
    
    let "MID_OF_MAX_PERCENT = ($MAX_PERCENT/2)"
    let "POSITION = (($POSITION * $MAX_VALUE) / $MAX_PERCENT)"

    if [[ "$DIRECTION" = "$AXE_X" && $POSITION_IN_PERCENT_X -gt $MID_OF_MAX_PERCENT ]] 
    then
        let "POSITION = ($POSITION - ($SIZE_TEXT * $SIZE)/2)"

    elif [[ $POSITION_IN_PERCENT_Y -gt $MID_OF_MAX_PERCENT ]]
    then
        let "POSITION = ($POSITION - ($MARGIN_BOTTOM)/2)"
    fi

    echo "$POSITION"
}
