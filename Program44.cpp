//
//  main.cpp
//  Projecteuler44
//
//  Created by Gellért Peresztegi- Nagy on 2016. 03. 10..
//  Copyright © 2016. Gellért Peresztegi- Nagy. All rights reserved.
//

#include <iostream>
#include <vector>
#include <cmath>
using namespace std;

static bool isPentagonal(long x){
    double f = sqrt((2.0*x+1.0/12.0)/3.0) + 1.0/6.0;
    return abs(f-round(f))<0.000001;
}

int main(int argc, const char * argv[]) {
    time_t time = clock();
    
    vector<long> pentagonals;
    
    int n = 1;
    
    while(true){
        int current = n*(3*n-1)/2;
        
        for(vector<long>::reverse_iterator it = pentagonals.rbegin();it!=pentagonals.rend();it++){
            if(isPentagonal(current + *it) && isPentagonal(current - *it)){
                cout<<"Solution: "<<current - *it<<endl;
                cout<<"Time: "<<(clock()-time)/(double)CLOCKS_PER_SEC<<"s"<<endl;
                return 0;
            }
        }
        
        pentagonals.insert(pentagonals.end(),current);
        n++;
    }
}


