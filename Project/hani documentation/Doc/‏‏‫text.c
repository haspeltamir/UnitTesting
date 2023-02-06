//hw02-2.c
/*
ori azuviv
208741009
home work 02-2
*/
//(I = 1 , V = 5,  X = 10,  L = 50,  C = 100,  D = 500,  M = 1000)
int main()
{
	//(I = 1 , V = 5,  X = 10,  L = 50,  C = 100,  D = 500,  M = 1000)
	int num;
	int check;

	do {
		printf("please enter a number between 1-5000: ");
		check = scanf("%d", &num);
		{char c; while ((c = getchar()) != '\n' && c != EOF); };

	} while (num < 1 || num > 5000 || check < 1);

	while (num / 1000 != 0)
	{
		num -= 1000;
		printf("M");
	}
}
/*
output -
please enter a number between 1-5000: 2457
MMCCCCLVII
C:\Users\USER\source\repos\HOME WORK\hw02-2\x64\Debug\hw02-2.exe (process 18648) exited with code 0.
Press any key to close this window . . .

*/