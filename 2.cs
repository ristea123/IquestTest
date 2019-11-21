/*
Sa verific cate litere au aceeasi pozitie ca in alphabet intr un cuvant(un string care are DOAR litere, mici sau mari)
Exemple 
abcd – 4
abdcd – 2 (a,b)
Abbc – 2(A,b)
cBCd – 3(B,C,d)
*/

static int Solve(string word)
{
	int count = 0;
	for (int i = 0; i < word.Length; i++)
	{
		int alphaPoz;
		if (word[i] >= 'A' && word[i] <= 'Z')
			alphaPoz = word[i] - 'A';
		else
			alphaPoz = word[i] - 'a';
		if (i == alphaPoz)
			count++;
	}
	return count;
}