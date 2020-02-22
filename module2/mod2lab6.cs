// Create a do loop, also known as a do..while loop
// Note that with the do loop, the loop will run at least once regardless of the value of x
// which is due to the condition not being checked until the end.
// Experiment with this by setting x to a value greater than 5 and run the code
int x = 0;
do
{
    Console.WriteLine(x);
    x++;
} while (x < 5);