#!/bin/bash
#
# Script : ryser_tag_images.sh
# using imagemagick to write text on all images in active folder using heading to choose the position of the text.
# Ryser tom T.IS-E1b
# 21.12.2018

shopt -s -o nounset

#start of headings declaration
declare N="North"
declare E="East"
declare S="South"
declare W="West"
#end

declare COLOR=red
declare SIZE=20
declare DATETIME=$(date +"%T");

declare target
declare TEXT

 #syntax for the call of the script
declare SYNTAX="Please use this syntax : /tag_images.sh {target folder} {text to add in image} {Position in heading [NW]}"

#function to modify an image, adding the choosen text and the time of execution
function MODIFY_IMAGE {
    declare image="$1"
    declare GRAVITY="$2"
    # "convert" is imagemagick, 
    #-pointsize is the font size for the text
    #-gravity is an anchor for the text
    #-fill is the font color
    #-annotate is the shift of the text and the text
    # and last is the target to save file and name
    convert $image -pointsize $SIZE -gravity $GRAVITY -fill $COLOR -annotate +10+10 "$TEXT" $target/$image
    convert $target/$image -pointsize $SIZE -gravity SouthEast -annotate +0+0 "$DATETIME" $target/$image

}

#function that change the last parameter enter when calling the script in a usable format for imagemagick
function HEADING_CONVERTOR {
    local PARAM=$1
    local PARAM1
    local PARAM2
    local RESULT
    local PARAMS

    NB_PARAM="${PARAM//[^s]}"
    PARAM1="${PARAM:0:1}"
    PARAM2="${PARAM:1:1}"
    PARAMS=("$PARAM1" "$PARAM2" )

    for i in "${PARAMS[@]}"; do
        case $i in
        "N")
        RESULT+=$N
        ;;
        "E")
        RESULT+=$E
        ;;
        "S")
        RESULT+=$S
        ;;
        "W")
        RESULT+=$W
        ;;
        *)
        Message="A heading was wrong only use letter (N, E, S, W) "
        ;;
        esac
    done
    echo $RESULT
}

if [[ $# -ne 3 ]]; then
    echo $SYNTAX
    exit -1
else
    target=$1
    TEXT=$2
    HEADING=$(HEADING_CONVERTOR $3)

    #create folder if doesn't exist
    [[ -d $target ]] || mkdir $target

    #for each file with .jpg extension
    for file in *.jpg; 
    do 
        MODIFY_IMAGE $file $HEADING
        echo "$file done : position : $HEADING"
    done
fi

