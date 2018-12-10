#!/bin/bash
#
# Script : F_toC.sh
# Farenheit to Celsius temperature conversion
# Ryser tom T.IS-E1b
# 04.12.2018

shopt -s -o nounset
declare farenheit_temp
declare celsius_temp

read -p "Enter a Farenheit temperature : " farenheit_temp
echo 
let "celsius_temp = 5 * ( $farenheit_temp - 32 ) / 9"
echo $celsius_temp