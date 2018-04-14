#include <iostream>
#include <cmath>
#include <iomanip>

using namespace std;

void bubblesort(int sArray[],int SIZE);

int main(){
	
int Array[5] = {62,22,12,11,25};

	cout << bubblesort(Array,5);



return 0;

}


void bubblesort(int sArray[], int SIZE){
	int memory;
	int j;
	int i;
	for(j = 0;j<SIZE;j++){
		
		for( i = 0; i < SIZE;i++){
			if(sArray[i]>sArray[i+1]){
				memory= sArray[i+1];
				sArray[i+1] = sArray[i];
				sArray[i] = memory;
				
			}
			
			
		}
	
		
		
		
		
		
	}
	
	
	
}
