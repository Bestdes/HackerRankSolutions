var n = 6;
var k = 3;
var ar = [1, 3, 2, 6, 1, 2];

console.log(divisibleSumPairs(n, k, ar));

/* This is the solution to the Hacker Rank Problem: Divisible Sum Pairs */

// Complete the divisibleSumPairs function below.
function divisibleSumPairs(n, k, ar) {
    var numOfDPairs = 0;
    var baseNum, i, j;

    for(i = 0; i <= n; i++){
        baseNum = ar[i];

        console.log(baseNum);

        for(j = i + 1; j <= n; j++) {
            if((baseNum + ar[j]) % k == 0) {
                numOfDPairs++;
            }
        }
    }
    return numOfDPairs;
}
