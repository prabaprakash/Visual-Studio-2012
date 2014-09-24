#pragma once
#include "Praba.H"

RegularExpessions::RegularExpessions()
{
}
char RegularExpessions::RemoveRedundant(char a[])
{
 int le=strlen(a);
	char b[]="";
	int co=0;
	//b[0]=a[0];
	int cou=0;
	for(int i=0;i<strlen(a);i++)
	{
		for (int j = 0; j < strlen(b); j++)
		{
			if(b[j]==a[i])
			{
				co++;
			}
		}
		if(co>0)
		{
			co=0;
		}
		else{
			b[cou]=a[i];
		//	printf("%c",b[cou]);
			cou++;
		}
		
		
	}

  /*for(int l=0;l<cou;l++)
	{
		cout<<b[l];
	}
	*/
	return b[0];
}

