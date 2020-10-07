function findMinDays(profit,prices) {

    // Complete the findMinDays function below.
    return -1;
}

function processData(input) {
    var data = input.split("\n");

    var prices = data[1].split(" ");
    var profit = [];
    for(var i = 0; i<data[0].split(" ")[1]; i++){
        profit.push(data[2+i]);
    }
    var result= findMinDays(profit,prices);

    // Do not remove below line
    console.log(result);
    // Do not print anything after this line
}

process.stdin.resume();
process.stdin.setEncoding("ascii");
_input = "";
process.stdin.on("data", function (input) {
    _input += input;
});

process.stdin.on("end", function () {
    processData(_input);
});