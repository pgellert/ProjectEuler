//
//  main.cpp
//  Projecteuler45
//
//  Created by Gellért Peresztegi- Nagy on 2016. 03. 13..
//  Copyright © 2016. Gellért Peresztegi- Nagy. All rights reserved.
//

#include <iostream>
#include <cmath>
using namespace std;

static bool isPentagonal(long x){
    double f = sqrt((2.0*x+1.0/12.0)/3.0) + 1.0/6.0;
    return abs(f-round(f)) < 0.000001;
}

static bool isTriangle(long x){
    double f = sqrt(2.0*x+0.25) - 0.5;
    return abs(f-round(f)) < 0.000001;
}

static bool isHexagonal(long x){
    double f = sqrt(0.5*x+0.0625) + 0.25;
    return abs(f-round(f)) < 0.000001;
}

int main(int argc, const char * argv[]) {
    time_t time = clock();
    
    long i = 40756;
    
    while(true){
        if(isPentagonal(i) && isTriangle(i) && isHexagonal(i)){
            break;
        }
        i++;
    }
    
    cout<<"Solution: "<<i<<endl;
    cout<<"Time: "<<((clock()-time)/((double)CLOCKS_PER_SEC))<<"s"<<endl;
    
    
    return 0;
}
