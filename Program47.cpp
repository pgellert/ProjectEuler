//
//  main.cpp
//  Projecteuler47
//
//  Created by Gellért Peresztegi- Nagy on 2016. 03. 14..
//  Copyright © 2016. Gellért Peresztegi- Nagy. All rights reserved.
//

#include <iostream>
#include <vector>
#include <cmath>
using namespace std;

bool hasFourDistinctPrimeFactors(int num){
    int numberOfDistinctPrimeFactors = 0;
    
    for (int i = 2; num != 1; i++) {
        if(num % i == 0){
            numberOfDistinctPrimeFactors++;
            
            do {
                num/=i;
            } while(num % i == 0);
        }
    }
    
    return numberOfDistinctPrimeFactors == 4;
}

int main(int argc, const char * argv[]) {
    time_t time = clock();
    
    int numberOfConsecutivesInRow = 0;
    
    int i = 1;
    
    while(numberOfConsecutivesInRow < 4){
        if(hasFourDistinctPrimeFactors(i)){
            numberOfConsecutivesInRow++;
        } else{
            numberOfConsecutivesInRow = 0;
        }
        i++;
    }
    
    
    cout<<"Solution: "<<i-4<<endl;
    cout<<"Time: "<<(clock()-time)/(double)CLOCKS_PER_SEC<<"s"<<endl;
    return 0;
}
