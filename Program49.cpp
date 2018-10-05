//
//  main.cpp
//  Projecteuler49
//
//  Created by Gellért Peresztegi- Nagy on 2016. 03. 14..
//  Copyright © 2016. Gellért Peresztegi- Nagy. All rights reserved.
//

#include <iostream>
#include <cmath>
using namespace std;

bool usesSameDigits(int a, int b, int c){
    int digitsA[10] = {0};
    do{
        digitsA[a % 10]++;
        a /= 10;
    } while(a > 0);
    
    int digitsB[10] = {0};
    do{
        digitsB[b % 10]++;
        b /= 10;
    } while(b > 0);
    
    int digitsC[10] = {0};
    do{
        digitsC[c % 10]++;
        c /= 10;
    } while(c > 0);
    
    for (int i = 0; i < 10; i++) {
        if(digitsA[i] != digitsB[i] || digitsA[i] != digitsC[i]){
            return false;
        }
    }
    return true;
}

bool isPrime(int num){
    if(num % 2 == 0){
        return false;
    }
    for (int i = 3; i <= sqrt(num); i+=2) {
        if(num % i == 0){
            return false;
        }
    }
    return true;
}

int main(int argc, const char * argv[]) {
    time_t time = clock();
    
    
    for (int i = 1000; i < 10000; i++) {
        if(isPrime(i)){
            int max = (10000 - i) / 2;
            for (int j = 1; j < max; j++) {
                int second = i + j;
                int third = i + 2 * (j);
                if(isPrime(second) && isPrime(third) && usesSameDigits(i,second,third)){
                    if(i != 1487){
                        cout<<"Solution: "<<i<<second<<third<<endl;
                        cout<<"Time: "<<(clock()-time)/(double)CLOCKS_PER_SEC<<"s"<<endl;
                        return 0;
                    }
                }
            }
        }
    }
    
    return 0;
}
