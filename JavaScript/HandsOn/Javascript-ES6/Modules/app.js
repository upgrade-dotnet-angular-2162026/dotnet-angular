// app.js
const logger = require('./logger');
import { logInfo, logError } from './logger.js';

logger.logInfo("Application started");
logger.logError("Something went wrong");
console.log(`Current log level: ${logger.logLevel.INFO}`);
logInfo("This is an info message");
logError("This is an error message");