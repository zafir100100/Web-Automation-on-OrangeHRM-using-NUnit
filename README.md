# Web-Automation-on-OrangeHRM-using-NUnit

This repository contains an automated testing framework for the OrangeHRM website using Selenium WebDriver with NUnit in C#. The framework implements a Page Object Model (POM) design pattern for better maintainability and scalability. It covers common actions like logging in, verifying user credentials, and navigating through the dashboard. The tests are organized to follow best practices, and the framework includes reusable methods for handling browser interactions. The repository is ideal for anyone looking to set up automated testing for web applications with a clean and modular approach.

## Video

https://github.com/user-attachments/assets/69aa8c39-27a2-486b-92c2-154bdd1a8331

## Test Scenario: "Admin Login with Correct Credentials"

**Test Steps:**

1. **Launch the Browser:**
   - Open the browser and navigate to the OrangeHRM website URL: `https://opensource-demo.orangehrmlive.com`.

2. **Enter Login Credentials:**
   - On the login page, enter valid credentials:
     - **Username:** admin
     - **Password:** admin123

3. **Click Login Button:**
   - After entering the credentials, click on the "Login" button.

4. **Verify Login Success:**
   - Once logged in, verify that the current URL contains the text `dashboard`.

5. **Close the Browser:**
   - After the verification, close the browser to complete the test.

## Screenshot (Report)

![image](https://github.com/user-attachments/assets/8b829da4-2ee9-4b66-8a49-1ed7c74a2566)


