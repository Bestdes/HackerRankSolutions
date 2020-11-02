/* This is the Grading Students Solution */

var testingGrades = [73, 67, 40, 33];

function gradingStudents(grades) {
    // Write your code here

    var count = 0;

    grades.forEach(element => {

        if(element >= 38) {

            var isDivBy5Plus1 = (element + 1) % 5 === 0 ? true : false;
            var isDivBy5Plus2 = (element + 2) % 5 === 0 ? true : false; 

            if(isDivBy5Plus1) {
                element += 1;
            }
            else if (isDivBy5Plus2) {
                element += 2;
            }
        }
        grades[count] = element;
        count++;
    });
    console.log(grades);
    return grades;
}

gradingStudents(testingGrades);