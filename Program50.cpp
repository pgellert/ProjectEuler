//
//  main.cpp
//  Projecteuler50
//
//  Created by Gellért Peresztegi- Nagy on 2016. 03. 14..
//  Copyright © 2016. Gellért Peresztegi- Nagy. All rights reserved.
//

#include <iostream>
#include <vector>
#include <cmath>
using namespace std;

bool isPrime(long num){
    if(num % 2 == 0){
        return false;
    }
    double sqrtNum = sqrt(num);
    for (int i = 3; i <= sqrtNum; i+=2) {
        if(num % i == 0){
            return false;
        }
    }
    return true;
}

int main(int argc, const char * argv[]) {
    time_t time = clock();
    vector<long> primes;
    primes.insert(primes.end(), 2);
    
    long maxLength = 1;
    long maxNum = -1;
    
    long i = 3;
    long lastSum = 2;
    int lastLenght = 1;
    
    const int max = 1000000;
    
    while(i < max){
        if(isPrime(i)){
            primes.insert(primes.end(), i);
            
            lastSum += i;
            lastLenght++;
            
            long sum = lastSum;
            int length = lastLenght;
            
            if(isPrime(sum)){
                if(sum < max){
                    maxLength = length;
                    maxNum = sum;
                }
            } else{
                for (vector<long>::iterator j = primes.begin(); j != primes.end()-1; j++) {
                    sum -= *j;
                    length--;
                    if(isPrime(sum) && sum < max && length > maxLength){
                        maxLength = length;
                        maxNum = sum;
                        break;
                    }
                    
                }
            }
        }
        i+=2;
    }
    
    /*for (int i = 3; i < 1000000; i += 2) {
        if(isPrime(i)){
            
            int length = 0;
            
            //Current i - sum of the consecutive prime sequence
            int num = i;

            for(vector<int>::iterator p = primes.begin(); p != primes.end(); p++){
                num -= *p;
                length++;
                if(num < 0) {
                    do{
                        num += *(p-length);
                        length--;
                    } while(num < 0);
                    
                }
                if(num == 0){
                    if(length > maxLength){
                        maxLength = length;
                        maxNum = i;
                        cout<<maxNum<<endl;
                    }
                }
            }
            
            primes.insert(primes.end(), i);
        }
    }*/
    
    cout<<"Solution: "<<maxNum<<endl;
    cout<<"Time: "<<(clock()-time)/(double)CLOCKS_PER_SEC<<"s"<<endl;
    return 0;
}
