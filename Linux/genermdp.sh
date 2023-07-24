#!/bin/bash
# Script to generate a random password in a variable called mdp composed of x random letters with x the first paramater
#If there is no parameter or more than one x is set to 10

if [ $# -eq 1 ] 
then
    x=$1
else
    x=10
fi

alea=$((1 + $RANDOM % 26))
alphabet="abcdefghijklmnopqrstuvwxyz"

for i in $(seq 2 $x)
do
    alea=$((1 + $RANDOM % 26))
    mdp=$mdp$(cut -c $alea <<< $alphabet)
done

echo $mdp





