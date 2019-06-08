
/*************************************************************
 *  Optimized  Solution
-*************************************************************/
function arithmicSum(n) {
    return (n * (n + 1)) / 2
}

function arithmicSequence(limit)  {
    limit = limit -1;
    const threes = 3 * arithmicSum(Math.floor(limit/3));
    const fives = 5 * arithmicSum(Math.floor(limit/5));
	const fifteens = 15 * arithmicSum(Math.floor(limit/15));
	return parseInt(threes + fives - fifteens)
}

console.log(arithmicSequence(1000))
