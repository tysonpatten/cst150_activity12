Console.WriteLine("Enter a file name: ");
string fileName = Console.ReadLine();


// open file
StreamReader sr = new StreamReader(fileName);


// read file
string line = sr.ReadLine();

// counter
int count = 0;

while (line != null) 
{
    string[] words = line.Split(' '); // split the line into words
    foreach (string word in words) // for each word
    {
        if (word.EndsWith("t") || word.EndsWith("e")) // if the word ends with t or e
        {
            count++; // increment the count
        }
    }
    line = sr.ReadLine(); // read the next line
}

// close the file
sr.Close();

// output results
Console.WriteLine("There are " + count + " words that end with t or e.");

Console.ReadLine();
