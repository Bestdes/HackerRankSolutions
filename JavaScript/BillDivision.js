var bill = [3,10,2,9];

bonAppetit(bill, 1, 12);

function bonAppetit (bill, k, b) {

    var totalBill, correctSplitBill;
    totalBill = 0;

    bill.forEach(element => {
        totalBill += element;
    });

    totalBill -= bill[k];
    correctSplitBill = totalBill/(2);

    if(correctSplitBill === b) {
        /* return "Bon Appetit"; */
        return process.stdout.write("Bon Appetit");
    }
    else {
        console.log(b - correctSplitBill);
        return b - correctSplitBill;
    }

}
