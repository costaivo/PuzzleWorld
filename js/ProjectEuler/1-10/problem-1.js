/*
Problem 1 : Multiples of 3 and 5
If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

Find the sum of all the multiples of 3 or 5 below 1000.
*/


process.stdin.resume();
process.stdin.setEncoding('ascii');

var input_stdin = "";
var input_stdin_array = "";
var input_currentline = 0;

process.stdin.on('data', function (data) {
    input_stdin += data;
});

process.stdin.on('end', function () {
    input_stdin_array = input_stdin.split("\n");
    main();    
});

function readLine() {
    return input_stdin_array[input_currentline++];
}

/////////////// ignore above this line ////////////////////

function main() {
    var t = parseInt(readLine());
    for(var a0 = 0; a0 < t; a0++){
        var n = parseInt(readLine());
        if (n > 3) {
            let sum = 0;
            n = n - 1;
           sum =  SumDivisbleBy(3, n) + SumDivisbleBy(5, n) - SumDivisbleBy(15, n);
            console.log(sum);
        }
    }

}


process.stdin.resume();
process.stdin.setEncoding('ascii');

var input_stdin = "";
var input_stdin_array = "";
var input_currentline = 0;

process.stdin.on('data', function (data) {
    input_stdin += data;
});

process.stdin.on('end', function () {
    input_stdin_array = input_stdin.split("\n");
    main();    
});

function readLine() {
    return input_stdin_array[input_currentline++];
}

/////////////// ignore above this line ////////////////////

function main() {
    var t = parseInt(readLine());
    for(var a0 = 0; a0 < t; a0++){
        var n = parseInt(readLine());
        if (n > 3) {
            let sum = 0;
            n = n - 1;
           sum =  SumDivisbleBy(3, n) + SumDivisbleBy(5, n) - SumDivisbleBy(15, n);
            console.log(sum);
        }
    }

}
function SumDivisbleBy( n,  p){
    let sum = n * (p / n) * ((p / n) + 1) / 2;
    return Math.round(sum);
}


