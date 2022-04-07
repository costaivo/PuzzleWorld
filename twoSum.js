var twoSum = function(nums, target) {
    const store = {}
    for(let i = 0; i < nums.length; i++){
      let cur = nums[i]
      let diff = target - cur
      console.log(`i is ${i},cur:${cur} diff ${diff}`)
      
      // Return answer if the current number was a diff from a previous number
      if(store[cur]!==undefined) {
        console.log(`cur value is ${cur} n diff is ${diff}, i is ${i}`)
        return [store[cur], i]
      }
      // Set diff to current index in store
      else 
      {store[diff] = i}
      
      console.log(store)
      console.log('\n')
    }
};

const result = twoSum([6,3,5,5,6],10)
console.log(result)