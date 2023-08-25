int [] data = { 3, 17, 19, 26, 50, 52, 54, 69, 83, 84 };

int searched_Number = 52;
bool number_Found = false;
int begin = 0;
int end = data.Length - 1;
int half;

do
{
    half = begin + (end - begin) / 2;
    if (data[half] == searched_Number)
    {
        Console.WriteLine("Number found at index " + half + ".");
        number_Found = true;
        break;
    }
    else if (data[half] > searched_Number)
    {
        end = half - 1;
    }
    else
    {
        begin = half + 1;
    }
} while (begin <= end);
if (!number_Found)
{
    Console.WriteLine("Number not found.");
}