Feature: Logging Events and Errors

Scenario: Logging an INFO message
Given an log file "application.log"
When a message "User logged in" with level "INFO" is logged
Then "User logged in" should be written to "application.log" with timestamp and [INFO]

Scenario: Logging a WARNING message
Given an log file "application.log"
When a message "Failed login attempt" with level "WARNING" is logged
Then "Failed login attempt" should be written to "application.log" with timestamp and [WARNING]

Scenario: Logging an empty message
Given an log file "application.log"
When a message "No log level specified" without a level is logged
Then "application.log" should contain a timestamp and [ERROR]
