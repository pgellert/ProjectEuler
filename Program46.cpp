//
//  main.cpp
//  Projecteuler46
//
//  Created by Gellért Peresztegi- Nagy on 2016. 03. 14..
//  Copyright © 2016. Gellért Peresztegi- Nagy. All rights reserved.
//

#include <iostream>
#include <vector>
#include <cmath>
using namespace std;

bool isPrime(int num){
    if(num == 2){
        return true;
    } else if(num % 2 == 0){
        return false;
    }
    
    for (int i = 3; i <= sqrt(num); i+=2) {
        if(num % i == 0){
            return false;
        }
    }
    
    return true;
}

bool isPowerBaseWhole(int num, int prime){
    double x = sqrt((num-prime)/2.0);
    return abs(round(x)-x)<0.000001;
}

int main(int argc, const char * argv[]) {
    time_t time = clock();
    int i = 3;
    vector<int> primes;
    primes.insert(primes.end(), 2);
    while(true){
        if(isPrime(i)){
            primes.insert(primes.end(), i);
        } else{
            bool canBeWrittenThatWay = false;
            for(int p : primes){
                if(isPowerBaseWhole(i, p)){
                    canBeWrittenThatWay = true;
                    break;
                }
            }
            if(!canBeWrittenThatWay){
                break;
            }
        }
        i+=2;
    }
    
    cout<<"Solution: "<<i<<endl;
    cout<<"Time: "<<(clock()-time)/(double)CLOCKS_PER_SEC<<"s"<<endl;
    return 0;
}
