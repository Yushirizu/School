// Write the code of
// 1. Defining a structure voiture with two int members named km and prix, an array of 9 characters named plaque
// 2. Declaring a variable structure Opel of type voiture
// 3. Define the value 53200 for the member km of the Opel structure
// 4. Write the declaration and the initalisation of the pointer pointing to the structur Opel
// 5. Find two methods by using pointers of the previous point to attribute the value 5400 to the member prix of Opel Structure

// 1.
struct voiture
{
    int km;
    int prix;
    char plaque[9];
};

// 2.
struct voiture Opel;

// 3.
Opel.km = 53200;

// 4.
struct voiture *ptrOpel = &Opel;

// 5.
(*ptrOpel).prix = 5400;
ptrOpel->prix = 5400;
