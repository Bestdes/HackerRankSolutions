var gameScores = [10, 5, 20, 20, 4, 5, 2, 25, 1];
breakingRecords(gameScores);


// Complete the breakingRecords function below.
function breakingRecords(scores) {

    var highScore = scores[0];
    var lowScore = scores[0];
    var recordHighBroken = 0;
    var recordLowBroken = 0;
    var recordArray;

    scores.forEach(element => {
        if (element > highScore) {
            highScore = element;
            recordHighBroken++;
        } 
        if(element < lowScore){
            lowScore = element;
            recordLowBroken++;
        }
    });

    recordArray = [recordHighBroken, recordLowBroken]
    
    return recordArray;
    /* return console.log(recordHighBroken + " " + recordLowBroken); */
    /* process.stdout.write(recordHighBroken + " " + recordLowBroken); */
    /* fs.createWriteStream(process.env.OUTPUT_PATH).write(`${recordHighBroken} + " " + ${recordLowBroken}`); */
}

