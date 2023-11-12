// Write a program that determine the number of vowels in a text of 100 characters

#include <stdio.h>
#include <stdlib.h>

int main()
{
    char text[100];
    int i, vowels = 0;

    printf("Enter a text of 100 characters: ");
    gets(text);

    for (i = 0; i < 100; i++)
    {
        if (text[i] == 'a' || text[i] == 'e' || text[i] == 'i' || text[i] == 'o' || text[i] == 'u')
        {
            vowels++;
        }
    }

    printf("The number of vowels in the text is: %d", vowels);

    return 0;
}