import { add, PI } from './math.js'
import { add as sum } from './math.js'
import log from './logger.js'
import * as MathUtil from './math.js' //export all
console.log(add(2, 3))
console.log(PI);
log('Hello');
console.log(sum(2, 3));
console.log(MathUtil.add(2, 3))
console.log(MathUtil.PI);