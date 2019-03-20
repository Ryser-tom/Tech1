#!/bin/bash
#
# Script : quiz_europe_capitals.sh
# quiz country capitals
# Ryser tom T.IS-E1b
# 08.01.2019

shopt -s -o nounset

declare SCORE
declare NB_QUESTIONS
declare COUNTRIES
declare COUNTRY
declare CAPITAL

declare SYNTAX="Please use this syntax : /$0 {file}"


function GETFILECOUNTRIES {
    local FILE=$1
    
    mapfile -t COUNTRIES < $FILE
}

function EXIT {
    echo "File not found!"
    exit -1
}

if [[ $# -ne 1 ]]; then
    echo $SYNTAX
    exit -1
else
    #if the file doesn't exist say it and close script
    [ -f $1 ] || EXIT

    SCORE=0
    NB_QUESTIONS=0
    GETFILECOUNTRIES $1

    while [ $NB_QUESTIONS -lt 10 ]
    do
        #get a random number between 0 and total of elements in array
        RANDOMNUMBER=$(( $RANDOM % ${#COUNTRIES[@]}))
        QUESTION=${COUNTRIES[RANDOMNUMBER]}
        #place the words in the string in an array
        QUESTION_CUT=( $QUESTION )
        COUNTRY=${QUESTION_CUT[0]}
        CAPITAL=${QUESTION_CUT[1]}

        echo "Country : $COUNTRY, capital ? "
        #wait 30 sec for the input of the user
        read -t 30 ANSWER
        if [[ $CAPITAL = $ANSWER ]]
        then
            echo "Right !"
            let "SCORE++"
        else
            echo "The answer was $CAPITAL !"
        fi
        let "NB_QUESTIONS++"
    done
    echo "The Score is $SCORE"
    
fi


