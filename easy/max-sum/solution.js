function getSum(arr) {
  let sum = 0;
  for (let i = 0; i < arr.length; i++) {
    const tempSum = i == 0 ? arr[i] + arr[i + 1] : sum + arr[i + 1];

    if (tempSum <= 0 || tempSum <= sum) {
      return sum;
    }
    sum = tempSum > sum ? tempSum : sum;
  }

  return sum;
}

function maxSumContiguous(arr) {
  let max = 0;
  const arrLength = arr.length;
  for (let i = 0; i < arrLength - 1; i++) {
    const iterationTotal = getSum(arr.slice(i));
    max = iterationTotal > max ? iterationTotal : max;
  }

  return max;
}

module.exports = maxSumContiguous;
