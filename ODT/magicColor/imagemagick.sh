#!/bin/bash
#
# Script : F_toC.sh
# Farenheit to Celsius temperature conversion
# Ryser tom T.IS-E1b
# 04.12.2018

shopt -s -o nounset

declare AXE_X=X
declare AXE_Y=Y
#start of headings declaration
declare N="North"
declare E="East"
declare S="South"
declare W="West"
#end


declare MAX_PERCENT=100
declare COLOR=red
declare SIZE=20
declare DENSITY=90
declare DATETIME=$(date +"%T");
declare MARGIN_WIDTH

declare target
declare TEXT
declare POSITION_IN_PERCENT_X=1
declare POSITION_IN_PERCENT_Y=1

 
declare SYNTAX="Please use this syntax : /tag_images.sh {target folder} {text to add in image} {Position in heading [NW]}"

function MODIFY_IMAGE {
    declare image="$1"
    convert $image -pointsize $SIZE -gravity North -fill $COLOR -annotate +10+10 "$TEXT" $target/$image
    convert $target/$image -pointsize $SIZE -gravity SouthEast -annotate +0+0 "$DATETIME" $target/$image

}

function HEADING_CONVERTOR {
    local PARAM=$1
    local PARAM1
    local PARAM2

    
    declare i=$((${#PARAM}))
    PARAM1="${PARAM:0:1}"
    PARAM2="${PARAM:1:1}"

    case "" in
    "1")
        do_this()
    ;;
    "2" | "3")
        do_what_you_are_supposed_to_do()
    ;;
    *)
        do_nothing()
    ;;
    esac
}

if [[ $# -ne 3 ]]; then
    echo $SYNTAX
    exit -1
else
    target=$1
    TEXT=$2
    HEADING_CONVERTOR $3
    MARGIN_WIDTH=${#TEXT}

    [[ -d $target ]] || mkdir $target

    for file in *.jpg; 
    do 
        MODIFY_IMAGE $file
        echo "$file done : position : $HEADING"
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
