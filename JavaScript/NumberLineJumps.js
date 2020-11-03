/* This is the Hacker Rank Solution to Number Line Jumps */


var x1 = 0;
var v1 = 3;
var x2 = 4;
var v2 = 2;

kangaroo(x1, v1, x2, v2);


// Complete the kangaroo function below.
function kangaroo(x1, v1, x2, v2) {

    var slopeRate = v1 - v2;
    var initialPositionDiff = x2 - x1;

    var numberOfHopsUntillEqual = 0;

    numberOfHopsUntillEqual = initialPositionDiff / slopeRate;
    /* console.log(slopeRate);
    console.log(numberOfHopsUntillEqual); */

    if(numberOfHopsUntillEqual > 0 && initialPositionDiff % slopeRate == 0) {
        /* console.log('YES'); */
        return 'YES';
        
    }
    else {
        /* console.log('NO'); */
        return 'NO';
        
    }
}