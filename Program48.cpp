//
//  main.cpp
//  Projecteuler48
//
//  Created by Gellért Peresztegi- Nagy on 2016. 03. 14..
//  Copyright © 2016. Gellért Peresztegi- Nagy. All rights reserved.
//

#include <iostream>
using namespace std;

int main(int argc, const char * argv[]) {
    time_t time = clock();
    
    const long devider = 10000000000;
    long number = 0;
    
    for (int i = 1; i <= 1000; i++) {
        long x = 1;
        for (int j = 1; j <= i; j++) {
            x = (x * i) % devider;
        }
        number = (number + x) % devider;
    }
    
    cout<<"Solution: "<<number<<endl;
    cout<<"Time: "<<(clock()-time)/(double)CLOCKS_PER_SEC<<"s"<<endl;
    return 0;
}
