//1.	Sa transform literele mici in litere mari intr un string.

static string makeUpperCase(string myStr)
{
	string newString = "";
	int asciiDiff = 'a' - 'A';
	foreach (var character in myStr)
	{
		char newCharacter = character;
		if (newCharacter >= 'a' && newCharacter <= 'z')
			newCharacter = newCharacter - AsciiDiff;//Aici e eroarea
		newString += newCharacter;
	}
	return newString;
}

