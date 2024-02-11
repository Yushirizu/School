// Write a C program that ask the user the size of an array that he want to use. Then appear a menu that purpose 5 choices:
//  1. Fill the array with random numbers from 1 to 42
//  2. Display the array
//  3. Rearrange the array randomly
//  4. Create a text file with the array elements
//  5. Exit

// All the different menu options are in different functions

#include <stdio.h>
#include <stdlib.h>
#include <time.h>

void fillArray(int *array, int size);

void displayArray(int *array, int size);

void rearrangeArray(int *array, int size);

void createFile(int *array, int size);

int main()
{
    int size;
    int choice;
    int *array;

    printf("Enter the size of the array: ");
    scanf("%d", &size);

    array = (int *)malloc(size * sizeof(int));

    do
    {
        printf("\n1. Fill the array with random numbers from 1 to 42\n");
        printf("2. Display the array\n");
        printf("3. Rearrange the array randomly\n");
        printf("4. Create a text file with the array elements\n");
        printf("5. Exit\n");
        printf("Enter your choice: ");
        scanf("%d", &choice);

        switch (choice)
        {
        case 1:
            fillArray(array, size);
            break;
        case 2:
            displayArray(array, size);
            break;
        case 3:
            rearrangeArray(array, size);
            break;
        case 4:
            createFile(array, size);
            break;
        case 5:
            printf("Goodbye!\n");
            break;
        default:
            printf("Invalid choice!\n");
            break;
        }
    } while (choice != 5);

    free(array);

    return 0;
}

void fillArray(int *array, int size)
{
    int i;

    srand(time(NULL));

    for (i = 0; i < size; i++)
    {
        array[i] = rand() % 42 + 1;
    }
}

void displayArray(int *array, int size)
{
    int i;

    for (i = 0; i < size; i++)
    {
        printf("%d ", array[i]);
    }
    printf("\n");
}

void rearrangeArray(int *array, int size)
{
    int i;
    int temp;
    int random;

    srand(time(NULL));

    for (i = 0; i < size; i++)
    {
        random = rand() % size;
        temp = array[i];
        array[i] = array[random];
        array[random] = temp;
    }
}

void createFile(int *array, int size)
{
    int i;
    FILE *file;

    file = fopen("array.txt", "w");

    for (i = 0; i < size; i++)
    {
        fprintf(file, "%d ", array[i]);
    }

    fclose(file);
}
