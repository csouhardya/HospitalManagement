# CarePlanHack Tickets - Difficulty Wise

These tickets intentionally do **not** reveal which part of the codebase contains the bug.

Your job is to read the problem, reproduce it, debug across the system, and decide where the fix belongs.

- Easy: 150 tickets
- Medium: 150 tickets
- Hard: 150 tickets

Do not open hints unless you are stuck.

---

# Easy Tickets

### Ticket 001: Creating a patient with an empty name crashes instead of showing a validation error.

**Problem Statement**

Creating a patient with an empty name crashes instead of showing a validation error.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 002: A patient born in the future can be created successfully.

**Problem Statement**

A patient born in the future can be created successfully.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 003: Emergency patients are forced to enter insurance details even when they should be admitted immediately.

**Problem Statement**

Emergency patients are forced to enter insurance details even when they should be admitted immediately.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 004: Deleted patients still appear in the patient search result.

**Problem Statement**

Deleted patients still appear in the patient search result.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 005: Deleted patients still appear on the dashboard count.

**Problem Statement**

Deleted patients still appear on the dashboard count.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 006: Searching patients with a blank search box returns inconsistent results.

**Problem Statement**

Searching patients with a blank search box returns inconsistent results.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 007: Patient search behaves differently for uppercase and lowercase names.

**Problem Statement**

Patient search behaves differently for uppercase and lowercase names.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 008: Creating two patients with the same name, date of birth, and mobile number is allowed.

**Problem Statement**

Creating two patients with the same name, date of birth, and mobile number is allowed.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 009: A patient mobile number with letters is accepted.

**Problem Statement**

A patient mobile number with letters is accepted.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 010: A patient email without a valid format is accepted.

**Problem Statement**

A patient email without a valid format is accepted.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 011: A patient details page breaks when an invalid patient id is opened.

**Problem Statement**

A patient details page breaks when an invalid patient id is opened.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 012: The patient list loads duplicate records after the page opens.

**Problem Statement**

The patient list loads duplicate records after the page opens.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 013: The patient list keeps showing the loading message when the request fails.

**Problem Statement**

The patient list keeps showing the loading message when the request fails.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 014: The patient list allows delete action without checking whether the patient exists.

**Problem Statement**

The patient list allows delete action without checking whether the patient exists.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 015: After deleting a patient, the page reloads more data than necessary.

**Problem Statement**

After deleting a patient, the page reloads more data than necessary.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 016: Creating a patient returns a success response even when the saved data is incomplete.

**Problem Statement**

Creating a patient returns a success response even when the saved data is incomplete.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 017: Patient creation does not return the location of the newly created record.

**Problem Statement**

Patient creation does not return the location of the newly created record.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 018: Patient outstanding amount can be initialized with an invalid value from outside.

**Problem Statement**

Patient outstanding amount can be initialized with an invalid value from outside.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 019: Patient created date depends on local server time instead of a consistent time source.

**Problem Statement**

Patient created date depends on local server time instead of a consistent time source.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 020: Gender accepts any random string value.

**Problem Statement**

Gender accepts any random string value.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 021: The gender dropdown does not include all expected options.

**Problem Statement**

The gender dropdown does not include all expected options.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 022: Search text containing special URL characters produces incorrect results.

**Problem Statement**

Search text containing special URL characters produces incorrect results.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 023: Opening patient details repeatedly causes repeated data requests.

**Problem Statement**

Opening patient details repeatedly causes repeated data requests.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 024: The patient detail screen shows raw date format instead of readable date.

**Problem Statement**

The patient detail screen shows raw date format instead of readable date.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 025: The patient detail screen shows negative outstanding amount without warning.

**Problem Statement**

The patient detail screen shows negative outstanding amount without warning.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 026: Login with empty username and password still sends a request.

**Problem Statement**

Login with empty username and password still sends a request.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 027: Login failure does not display the real reason to the user.

**Problem Statement**

Login failure does not display the real reason to the user.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 028: After login, the user role is stored incorrectly.

**Problem Statement**

After login, the user role is stored incorrectly.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 029: Logout clears more browser data than it should.

**Problem Statement**

Logout clears more browser data than it should.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 030: Protected pages can be opened even when the user is not logged in.

**Problem Statement**

Protected pages can be opened even when the user is not logged in.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 031: Some protected pages are accessible without authentication.

**Problem Statement**

Some protected pages are accessible without authentication.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 032: Expired-looking tokens are still treated as valid by the frontend.

**Problem Statement**

Expired-looking tokens are still treated as valid by the frontend.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 033: Invalid token responses do not redirect the user to login.

**Problem Statement**

Invalid token responses do not redirect the user to login.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 034: API errors are shown using generic alerts everywhere.

**Problem Statement**

API errors are shown using generic alerts everywhere.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 035: The app stores authentication data in an unsafe client-side location.

**Problem Statement**

The app stores authentication data in an unsafe client-side location.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 036: Hardcoded API URLs make the app hard to move between environments.

**Problem Statement**

Hardcoded API URLs make the app hard to move between environments.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 037: Dashboard keeps refreshing even after leaving the screen.

**Problem Statement**

Dashboard keeps refreshing even after leaving the screen.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 038: Dashboard shows stale data after a failed refresh.

**Problem Statement**

Dashboard shows stale data after a failed refresh.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 039: Dashboard requests all data just to show counts.

**Problem Statement**

Dashboard requests all data just to show counts.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 040: Dashboard revenue includes unpaid bills.

**Problem Statement**

Dashboard revenue includes unpaid bills.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 041: Dashboard appointment count includes cancelled appointments.

**Problem Statement**

Dashboard appointment count includes cancelled appointments.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 042: Appointment can be booked without a reason.

**Problem Statement**

Appointment can be booked without a reason.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 043: Appointment can be booked with an invalid patient id.

**Problem Statement**

Appointment can be booked with an invalid patient id.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 044: Appointment can be booked with an invalid doctor id.

**Problem Statement**

Appointment can be booked with an invalid doctor id.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 045: Appointment can be booked in the past.

**Problem Statement**

Appointment can be booked in the past.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 046: Appointment status accepts any random string.

**Problem Statement**

Appointment status accepts any random string.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 047: Cancelled appointments still appear as active appointments.

**Problem Statement**

Cancelled appointments still appear as active appointments.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 048: Cancelling a non-existing appointment crashes the request.

**Problem Statement**

Cancelling a non-existing appointment crashes the request.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 049: Cancelling an already cancelled appointment still returns success.

**Problem Statement**

Cancelling an already cancelled appointment still returns success.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 050: Booking confirmation does not show the booked appointment identifier.

**Problem Statement**

Booking confirmation does not show the booked appointment identifier.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 051: Appointment fee is hardcoded and cannot vary by doctor.

**Problem Statement**

Appointment fee is hardcoded and cannot vary by doctor.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 052: Appointment duration does not respect doctor configuration.

**Problem Statement**

Appointment duration does not respect doctor configuration.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 053: Doctors marked inactive still appear as available.

**Problem Statement**

Doctors marked inactive still appear as available.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 054: Doctor specialization accepts blank values.

**Problem Statement**

Doctor specialization accepts blank values.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 055: Doctor list includes inactive doctors where only active doctors should appear.

**Problem Statement**

Doctor list includes inactive doctors where only active doctors should appear.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 056: Doctor consultation duration can be zero.

**Problem Statement**

Doctor consultation duration can be zero.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 057: Doctor consultation duration can be negative.

**Problem Statement**

Doctor consultation duration can be negative.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 058: Billing accepts a bill without any items.

**Problem Statement**

Billing accepts a bill without any items.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 059: Billing accepts an item with empty item name.

**Problem Statement**

Billing accepts an item with empty item name.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 060: Billing accepts item quantity as zero.

**Problem Statement**

Billing accepts item quantity as zero.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 061: Billing accepts negative item quantity.

**Problem Statement**

Billing accepts negative item quantity.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 062: Billing accepts negative item rate.

**Problem Statement**

Billing accepts negative item rate.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 063: Bill discount can be greater than total amount.

**Problem Statement**

Bill discount can be greater than total amount.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 064: Bill tax amount is ignored in total calculation.

**Problem Statement**

Bill tax amount is ignored in total calculation.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 065: Bill total can become negative.

**Problem Statement**

Bill total can become negative.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 066: Bill total is calculated differently in different screens.

**Problem Statement**

Bill total is calculated differently in different screens.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 067: Paid amount can be greater than total bill amount.

**Problem Statement**

Paid amount can be greater than total bill amount.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 068: Negative payment amount reduces paid amount.

**Problem Statement**

Negative payment amount reduces paid amount.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 069: Fully paid bill can still be modified.

**Problem Statement**

Fully paid bill can still be modified.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 070: Cancelled bill can still receive payment.

**Problem Statement**

Cancelled bill can still receive payment.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 071: Bill status is stored as free text.

**Problem Statement**

Bill status is stored as free text.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 072: Billing item rows use the same object reference and update together.

**Problem Statement**

Billing item rows use the same object reference and update together.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 073: Adding the same bill item multiple times creates confusing totals.

**Problem Statement**

Adding the same bill item multiple times creates confusing totals.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 074: Prescription can be created without medicines.

**Problem Statement**

Prescription can be created without medicines.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 075: Prescription medicine days can be zero.

**Problem Statement**

Prescription medicine days can be zero.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 076: Prescription medicine days can be negative.

**Problem Statement**

Prescription medicine days can be negative.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 077: Prescription dosage accepts blank values.

**Problem Statement**

Prescription dosage accepts blank values.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 078: Discontinued medicine can still be selected.

**Problem Statement**

Discontinued medicine can still be selected.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 079: Same medicine can be added multiple times to one prescription.

**Problem Statement**

Same medicine can be added multiple times to one prescription.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 080: Admission can be created without a bed.

**Problem Statement**

Admission can be created without a bed.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 081: Admission can be created without a patient.

**Problem Statement**

Admission can be created without a patient.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 082: Discharge date can be before admission date.

**Problem Statement**

Discharge date can be before admission date.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 083: Discharged patient still appears as admitted.

**Problem Statement**

Discharged patient still appears as admitted.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 084: Bed number accepts duplicate values in the same ward.

**Problem Statement**

Bed number accepts duplicate values in the same ward.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 085: Occupied beds still appear as available.

**Problem Statement**

Occupied beds still appear as available.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 086: Report filters accept invalid date ranges.

**Problem Statement**

Report filters accept invalid date ranges.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 087: Report date filter includes records outside the selected date.

**Problem Statement**

Report date filter includes records outside the selected date.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 088: Revenue report shows bills with draft status.

**Problem Statement**

Revenue report shows bills with draft status.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 089: Search result returns too many rows without paging.

**Problem Statement**

Search result returns too many rows without paging.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 090: Large lists freeze the browser screen.

**Problem Statement**

Large lists freeze the browser screen.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 091: Some screens use browser alerts instead of page-level messages.

**Problem Statement**

Some screens use browser alerts instead of page-level messages.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 092: Some buttons can be clicked multiple times during save.

**Problem Statement**

Some buttons can be clicked multiple times during save.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 093: Save buttons stay enabled while request is in progress.

**Problem Statement**

Save buttons stay enabled while request is in progress.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 094: Validation messages are missing from create forms.

**Problem Statement**

Validation messages are missing from create forms.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 095: Forms submit even when required fields are empty.

**Problem Statement**

Forms submit even when required fields are empty.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 096: Numeric fields accept non-numeric values.

**Problem Statement**

Numeric fields accept non-numeric values.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 097: Date fields accept invalid dates.

**Problem Statement**

Date fields accept invalid dates.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 098: UI allows future appointment dates without checking clinic hours.

**Problem Statement**

UI allows future appointment dates without checking clinic hours.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 099: UI allows appointment time outside working hours.

**Problem Statement**

UI allows appointment time outside working hours.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 100: Back button after logout shows protected cached screen.

**Problem Statement**

Back button after logout shows protected cached screen.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 101: Unknown routes redirect users to dashboard even when not logged in.

**Problem Statement**

Unknown routes redirect users to dashboard even when not logged in.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 102: Table rows do not show an empty-state message.

**Problem Statement**

Table rows do not show an empty-state message.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 103: Long patient names break the table layout.

**Problem Statement**

Long patient names break the table layout.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 104: Search does not trim spaces before sending request.

**Problem Statement**

Search does not trim spaces before sending request.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 105: Duplicate spaces in names are saved as-is.

**Problem Statement**

Duplicate spaces in names are saved as-is.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 106: Leading and trailing spaces are saved in important text fields.

**Problem Statement**

Leading and trailing spaces are saved in important text fields.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 107: Some APIs return raw text errors while others return objects.

**Problem Statement**

Some APIs return raw text errors while others return objects.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 108: Some create actions return OK instead of a proper creation response.

**Problem Statement**

Some create actions return OK instead of a proper creation response.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 109: Some delete actions return OK even when nothing was deleted.

**Problem Statement**

Some delete actions return OK even when nothing was deleted.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 110: Some update-like behaviour is hidden inside create actions.

**Problem Statement**

Some update-like behaviour is hidden inside create actions.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 111: Some endpoints accept body data that should come from the route.

**Problem Statement**

Some endpoints accept body data that should come from the route.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 112: Some endpoints accept route data that should come from the body.

**Problem Statement**

Some endpoints accept route data that should come from the body.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 113: Some responses expose fields the user does not need.

**Problem Statement**

Some responses expose fields the user does not need.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 114: Some screens depend on lowercase JSON property names.

**Problem Statement**

Some screens depend on lowercase JSON property names.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 115: Some code assumes all requests always succeed.

**Problem Statement**

Some code assumes all requests always succeed.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 116: Some list screens do not handle empty arrays.

**Problem Statement**

Some list screens do not handle empty arrays.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 117: Some fields allow values that are longer than the database can store.

**Problem Statement**

Some fields allow values that are longer than the database can store.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 118: Some stored text values are not normalized.

**Problem Statement**

Some stored text values are not normalized.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 119: Some status values use different spelling for the same meaning.

**Problem Statement**

Some status values use different spelling for the same meaning.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 120: Some status values use different casing for the same meaning.

**Problem Statement**

Some status values use different casing for the same meaning.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 121: Patient creation accepts a date of birth that makes age over 150.

**Problem Statement**

Patient creation accepts a date of birth that makes age over 150.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 122: Doctor name accepts numbers only.

**Problem Statement**

Doctor name accepts numbers only.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 123: Medicine price can be negative.

**Problem Statement**

Medicine price can be negative.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 124: Medicine name accepts blank values.

**Problem Statement**

Medicine name accepts blank values.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 125: Bill item rate accepts too many decimal places.

**Problem Statement**

Bill item rate accepts too many decimal places.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 126: Payment amount accepts too many decimal places.

**Problem Statement**

Payment amount accepts too many decimal places.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 127: Insurance number accepts whitespace only.

**Problem Statement**

Insurance number accepts whitespace only.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 128: Emergency flag behaves inconsistently across screens.

**Problem Statement**

Emergency flag behaves inconsistently across screens.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 129: Created date is shown differently on different screens.

**Problem Statement**

Created date is shown differently on different screens.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 130: Patient search by mobile misses valid records with spaces.

**Problem Statement**

Patient search by mobile misses valid records with spaces.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 131: Search box does not clear previous result after clearing text.

**Problem Statement**

Search box does not clear previous result after clearing text.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 132: Details page does not show a friendly message for missing records.

**Problem Statement**

Details page does not show a friendly message for missing records.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 133: List page does not ask confirmation for important actions consistently.

**Problem Statement**

List page does not ask confirmation for important actions consistently.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 134: Multiple form fields share the same name attribute.

**Problem Statement**

Multiple form fields share the same name attribute.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 135: Some labels are not connected to their inputs.

**Problem Statement**

Some labels are not connected to their inputs.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 136: Some forms do not reset after successful save.

**Problem Statement**

Some forms do not reset after successful save.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 137: Some pages do not navigate after successful save.

**Problem Statement**

Some pages do not navigate after successful save.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 138: Some pages navigate before verifying save completion.

**Problem Statement**

Some pages navigate before verifying save completion.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 139: Some errors are swallowed silently.

**Problem Statement**

Some errors are swallowed silently.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 140: Some console logs expose sensitive request information.

**Problem Statement**

Some console logs expose sensitive request information.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 141: Some dropdowns have hardcoded values that should come from data.

**Problem Statement**

Some dropdowns have hardcoded values that should come from data.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 142: Some empty values are stored as empty strings instead of null.

**Problem Statement**

Some empty values are stored as empty strings instead of null.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 143: Some null values are shown directly in the UI.

**Problem Statement**

Some null values are shown directly in the UI.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 144: Some currency values are shown without formatting.

**Problem Statement**

Some currency values are shown without formatting.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 145: Some API names are inconsistent with the action they perform.

**Problem Statement**

Some API names are inconsistent with the action they perform.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 146: Some routes use verbs where nouns would be clearer.

**Problem Statement**

Some routes use verbs where nouns would be clearer.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 147: Some simple read operations change data unexpectedly.

**Problem Statement**

Some simple read operations change data unexpectedly.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 148: Some delete operations are actually soft deletes but the response does not say so.

**Problem Statement**

Some delete operations are actually soft deletes but the response does not say so.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 149: Some validation exists only on the client side.

**Problem Statement**

Some validation exists only on the client side.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 150: Some validation exists only on the server side.

**Problem Statement**

Some validation exists only on the server side.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---


# Medium Tickets

### Ticket 151: Two users can book the same doctor slot at nearly the same time.

**Problem Statement**

Two users can book the same doctor slot at nearly the same time.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 152: A cancelled appointment still prevents the same slot from being booked again.

**Problem Statement**

A cancelled appointment still prevents the same slot from being booked again.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 153: Doctor appointment overlap is checked only for exact same time, not overlapping ranges.

**Problem Statement**

Doctor appointment overlap is checked only for exact same time, not overlapping ranges.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 154: Doctor consultation duration is ignored when checking availability.

**Problem Statement**

Doctor consultation duration is ignored when checking availability.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 155: Patients can be booked with doctors whose specialization does not match the appointment reason.

**Problem Statement**

Patients can be booked with doctors whose specialization does not match the appointment reason.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 156: Patient duplicate detection fails when mobile number formatting differs.

**Problem Statement**

Patient duplicate detection fails when mobile number formatting differs.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 157: Soft-deleted patients can still be updated by direct request.

**Problem Statement**

Soft-deleted patients can still be updated by direct request.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 158: Soft-deleted patients can still receive appointments.

**Problem Statement**

Soft-deleted patients can still receive appointments.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 159: Patient search is vulnerable to unexpected input that changes the query meaning.

**Problem Statement**

Patient search is vulnerable to unexpected input that changes the query meaning.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 160: Patient search becomes slow as records grow.

**Problem Statement**

Patient search becomes slow as records grow.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 161: Large patient list requests return all rows instead of server-side pages.

**Problem Statement**

Large patient list requests return all rows instead of server-side pages.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 162: Dashboard becomes slow because it loads full datasets instead of aggregate values.

**Problem Statement**

Dashboard becomes slow because it loads full datasets instead of aggregate values.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 163: Revenue calculation changes depending on whether it comes from list, detail, or dashboard.

**Problem Statement**

Revenue calculation changes depending on whether it comes from list, detail, or dashboard.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 164: Bill creation trusts the amount sent by the screen instead of recalculating safely.

**Problem Statement**

Bill creation trusts the amount sent by the screen instead of recalculating safely.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 165: Bill creation can partially save a bill without all its items.

**Problem Statement**

Bill creation can partially save a bill without all its items.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 166: Bill payment can be applied twice if the user double-clicks quickly.

**Problem Statement**

Bill payment can be applied twice if the user double-clicks quickly.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 167: Two payments at the same time can produce an incorrect paid amount.

**Problem Statement**

Two payments at the same time can produce an incorrect paid amount.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 168: Paid bills can still have new items added.

**Problem Statement**

Paid bills can still have new items added.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 169: Discount rules stack in a way that can make the final amount invalid.

**Problem Statement**

Discount rules stack in a way that can make the final amount invalid.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 170: Insurance coverage is applied to items that should not be covered.

**Problem Statement**

Insurance coverage is applied to items that should not be covered.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 171: Expired insurance is accepted during billing.

**Problem Statement**

Expired insurance is accepted during billing.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 172: Refund-like negative payments are accepted without a proper refund workflow.

**Problem Statement**

Refund-like negative payments are accepted without a proper refund workflow.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 173: Prescription creation does not check patient allergies.

**Problem Statement**

Prescription creation does not check patient allergies.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 174: Prescription creation does not check whether the doctor is active.

**Problem Statement**

Prescription creation does not check whether the doctor is active.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 175: Prescription creation allows duplicate medicines with conflicting dosage.

**Problem Statement**

Prescription creation allows duplicate medicines with conflicting dosage.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 176: Prescription history can expose data for another patient by changing an id.

**Problem Statement**

Prescription history can expose data for another patient by changing an id.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 177: Admission allows the same patient to be actively admitted twice.

**Problem Statement**

Admission allows the same patient to be actively admitted twice.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 178: Admission allows two active patients in the same bed.

**Problem Statement**

Admission allows two active patients in the same bed.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 179: Bed occupancy can become wrong if discharge fails halfway.

**Problem Statement**

Bed occupancy can become wrong if discharge fails halfway.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 180: Discharge updates patient state and bed state without safe all-or-nothing behaviour.

**Problem Statement**

Discharge updates patient state and bed state without safe all-or-nothing behaviour.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 181: Reports can read uncommitted data and show incorrect numbers.

**Problem Statement**

Reports can read uncommitted data and show incorrect numbers.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 182: Reports filter dates using expressions that prevent index usage.

**Problem Statement**

Reports filter dates using expressions that prevent index usage.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 183: Age-based report gives wrong results around birthdays.

**Problem Statement**

Age-based report gives wrong results around birthdays.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 184: Age calculation returns misleading values for future dates.

**Problem Statement**

Age calculation returns misleading values for future dates.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 185: Monthly revenue report misses records from the last day depending on time.

**Problem Statement**

Monthly revenue report misses records from the last day depending on time.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 186: Login accepts disabled users.

**Problem Statement**

Login accepts disabled users.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 187: Login compares passwords in an unsafe way.

**Problem Statement**

Login compares passwords in an unsafe way.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 188: Token expiration policy is too long for the application risk.

**Problem Statement**

Token expiration policy is too long for the application risk.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 189: Token validation allows tokens that should be rejected.

**Problem Statement**

Token validation allows tokens that should be rejected.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 190: Refresh token records can be reused multiple times.

**Problem Statement**

Refresh token records can be reused multiple times.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 191: Refresh token records are stored in a risky format.

**Problem Statement**

Refresh token records are stored in a risky format.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 192: Role checks exist in the interface but not reliably on the server.

**Problem Statement**

Role checks exist in the interface but not reliably on the server.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 193: Users can perform actions outside their role by calling APIs directly.

**Problem Statement**

Users can perform actions outside their role by calling APIs directly.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 194: Admin-only operations are available without a proper permission check.

**Problem Statement**

Admin-only operations are available without a proper permission check.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 195: Authentication and authorization do not run in the expected order.

**Problem Statement**

Authentication and authorization do not run in the expected order.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 196: Cross-origin access is too permissive for a hospital system.

**Problem Statement**

Cross-origin access is too permissive for a hospital system.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 197: Error responses leak internal exception details.

**Problem Statement**

Error responses leak internal exception details.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 198: Unhandled exceptions do not return a consistent error object.

**Problem Statement**

Unhandled exceptions do not return a consistent error object.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 199: Validation errors do not return field-level details.

**Problem Statement**

Validation errors do not return field-level details.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 200: Request logs do not include enough context to debug failed operations.

**Problem Statement**

Request logs do not include enough context to debug failed operations.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 201: Request logs expose information that should not be logged.

**Problem Statement**

Request logs expose information that should not be logged.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 202: Long-running report generation blocks the request thread.

**Problem Statement**

Long-running report generation blocks the request thread.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 203: Some asynchronous-looking operations are actually synchronous.

**Problem Statement**

Some asynchronous-looking operations are actually synchronous.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 204: Some synchronous database calls should be async under load.

**Problem Statement**

Some synchronous database calls should be async under load.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 205: Some code risks deadlock by blocking on asynchronous results.

**Problem Statement**

Some code risks deadlock by blocking on asynchronous results.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 206: Some background-like work can fail silently.

**Problem Statement**

Some background-like work can fail silently.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 207: Some database connections are not disposed safely on failure.

**Problem Statement**

Some database connections are not disposed safely on failure.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 208: Some transactions are started but not passed to all commands.

**Problem Statement**

Some transactions are started but not passed to all commands.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 209: Mixed data access patterns cause inconsistent behaviour for the same operation.

**Problem Statement**

Mixed data access patterns cause inconsistent behaviour for the same operation.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 210: Some repository methods return data that callers can further misuse.

**Problem Statement**

Some repository methods return data that callers can further misuse.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 211: Some services contain both validation, data access, and response-shaping logic.

**Problem Statement**

Some services contain both validation, data access, and response-shaping logic.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 212: Some controllers contain business decisions that should be centralized.

**Problem Statement**

Some controllers contain business decisions that should be centralized.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 213: Some update operations replace entire records and accidentally wipe fields.

**Problem Statement**

Some update operations replace entire records and accidentally wipe fields.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 214: Some list queries track data unnecessarily and increase memory usage.

**Problem Statement**

Some list queries track data unnecessarily and increase memory usage.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 215: Some detail queries include related data using inefficient patterns.

**Problem Statement**

Some detail queries include related data using inefficient patterns.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 216: Some repeated queries inside loops cause performance problems.

**Problem Statement**

Some repeated queries inside loops cause performance problems.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 217: Some calculated fields are stored and recalculated inconsistently.

**Problem Statement**

Some calculated fields are stored and recalculated inconsistently.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 218: Some status transitions are allowed even when the previous status makes them invalid.

**Problem Statement**

Some status transitions are allowed even when the previous status makes them invalid.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 219: Appointment can move directly from cancelled to completed.

**Problem Statement**

Appointment can move directly from cancelled to completed.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 220: Bill can move directly from unpaid to refunded without payment.

**Problem Statement**

Bill can move directly from unpaid to refunded without payment.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 221: Admission can move directly from discharged back to admitted.

**Problem Statement**

Admission can move directly from discharged back to admitted.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 222: Prescription can be edited after it should be locked.

**Problem Statement**

Prescription can be edited after it should be locked.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 223: Patient deletion does not check unpaid bills.

**Problem Statement**

Patient deletion does not check unpaid bills.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 224: Patient deletion does not check active admission.

**Problem Statement**

Patient deletion does not check active admission.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 225: Patient deletion does not check future appointments.

**Problem Statement**

Patient deletion does not check future appointments.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 226: Doctor deactivation does not handle future appointments.

**Problem Statement**

Doctor deactivation does not handle future appointments.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 227: Doctor deactivation does not prevent future scheduling through direct requests.

**Problem Statement**

Doctor deactivation does not prevent future scheduling through direct requests.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 228: Medicine discontinuation does not affect existing drafts.

**Problem Statement**

Medicine discontinuation does not affect existing drafts.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 229: Medicine discontinuation is not checked during prescription save.

**Problem Statement**

Medicine discontinuation is not checked during prescription save.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 230: Search query allows wildcard behaviour that users did not intend.

**Problem Statement**

Search query allows wildcard behaviour that users did not intend.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 231: Sorting accepts unsafe or unknown column names.

**Problem Statement**

Sorting accepts unsafe or unknown column names.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 232: Filtering accepts invalid field names and fails unpredictably.

**Problem Statement**

Filtering accepts invalid field names and fails unpredictably.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 233: Pagination metadata is missing from paged responses.

**Problem Statement**

Pagination metadata is missing from paged responses.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 234: Frontend and backend disagree about page numbering.

**Problem Statement**

Frontend and backend disagree about page numbering.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 235: Repeated dashboard polling continues after navigating away.

**Problem Statement**

Repeated dashboard polling continues after navigating away.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 236: Search sends multiple overlapping requests and shows older results last.

**Problem Statement**

Search sends multiple overlapping requests and shows older results last.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 237: Typing quickly in search can produce out-of-order displayed results.

**Problem Statement**

Typing quickly in search can produce out-of-order displayed results.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 238: Form submission can create duplicates when the button is clicked repeatedly.

**Problem Statement**

Form submission can create duplicates when the button is clicked repeatedly.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 239: Save operation does not disable the screen during processing.

**Problem Statement**

Save operation does not disable the screen during processing.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 240: Several requests have no cancellation behaviour.

**Problem Statement**

Several requests have no cancellation behaviour.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 241: Route parameter changes do not always refresh details correctly.

**Problem Statement**

Route parameter changes do not always refresh details correctly.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 242: Nested subscriptions make error handling inconsistent.

**Problem Statement**

Nested subscriptions make error handling inconsistent.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 243: Some subscriptions live longer than the component.

**Problem Statement**

Some subscriptions live longer than the component.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 244: Authentication failure inside one request can trigger repeated failing requests.

**Problem Statement**

Authentication failure inside one request can trigger repeated failing requests.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 245: Interceptor does not handle unauthorized responses consistently.

**Problem Statement**

Interceptor does not handle unauthorized responses consistently.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 246: Interceptor attaches token to every request, even where it should not.

**Problem Statement**

Interceptor attaches token to every request, even where it should not.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 247: Frontend stores role separately from token and can become inconsistent.

**Problem Statement**

Frontend stores role separately from token and can become inconsistent.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 248: Frontend trusts locally stored role for protected actions.

**Problem Statement**

Frontend trusts locally stored role for protected actions.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 249: Frontend total calculation differs from server-side total calculation.

**Problem Statement**

Frontend total calculation differs from server-side total calculation.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 250: Frontend date conversion changes the appointment time zone.

**Problem Statement**

Frontend date conversion changes the appointment time zone.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 251: Date-time submitted from the browser is interpreted differently by the server.

**Problem Statement**

Date-time submitted from the browser is interpreted differently by the server.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 252: Server local time causes inconsistent results across environments.

**Problem Statement**

Server local time causes inconsistent results across environments.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 253: Database date columns allow values without clear UTC/local policy.

**Problem Statement**

Database date columns allow values without clear UTC/local policy.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 254: Several important tables allow duplicate business records.

**Problem Statement**

Several important tables allow duplicate business records.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 255: Several important tables allow nulls where data is required.

**Problem Statement**

Several important tables allow nulls where data is required.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 256: Several important numeric columns allow invalid negative values.

**Problem Statement**

Several important numeric columns allow invalid negative values.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 257: Important relationship rules are enforced only by code, not by the database.

**Problem Statement**

Important relationship rules are enforced only by code, not by the database.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 258: Some deletes leave orphaned records.

**Problem Statement**

Some deletes leave orphaned records.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 259: Some views include deleted records.

**Problem Statement**

Some views include deleted records.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 260: Some stored procedures do not return enough information to the caller.

**Problem Statement**

Some stored procedures do not return enough information to the caller.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 261: Some stored procedures do not handle failure paths.

**Problem Statement**

Some stored procedures do not handle failure paths.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 262: Some stored procedures have no transaction even though they update multiple tables.

**Problem Statement**

Some stored procedures have no transaction even though they update multiple tables.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 263: Some stored procedures calculate totals differently from application code.

**Problem Statement**

Some stored procedures calculate totals differently from application code.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 264: Some report queries use patterns that prevent indexes from being used.

**Problem Statement**

Some report queries use patterns that prevent indexes from being used.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 265: Some queries use dirty reads where accuracy matters.

**Problem Statement**

Some queries use dirty reads where accuracy matters.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 266: Some functions are used in filters and cause slow scans.

**Problem Statement**

Some functions are used in filters and cause slow scans.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 267: Some tables have no useful indexes for common searches.

**Problem Statement**

Some tables have no useful indexes for common searches.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 268: Some common lookup values are stored as free text instead of controlled values.

**Problem Statement**

Some common lookup values are stored as free text instead of controlled values.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 269: Some repeated business strings are scattered throughout the application.

**Problem Statement**

Some repeated business strings are scattered throughout the application.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 270: Some data validation is impossible because the schema is too weak.

**Problem Statement**

Some data validation is impossible because the schema is too weak.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 271: Some APIs cannot be safely retried because they are not idempotent.

**Problem Statement**

Some APIs cannot be safely retried because they are not idempotent.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 272: Some payment actions can be repeated after browser refresh.

**Problem Statement**

Some payment actions can be repeated after browser refresh.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 273: Some booking actions can be repeated after browser refresh.

**Problem Statement**

Some booking actions can be repeated after browser refresh.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 274: Some create actions return enough data for duplicate resubmission.

**Problem Statement**

Some create actions return enough data for duplicate resubmission.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 275: Audit history is missing for sensitive operations.

**Problem Statement**

Audit history is missing for sensitive operations.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 276: Audit entries do not include who made the change reliably.

**Problem Statement**

Audit entries do not include who made the change reliably.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 277: Audit entries can be skipped if the operation fails halfway.

**Problem Statement**

Audit entries can be skipped if the operation fails halfway.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 278: Audit data can expose sensitive patient information.

**Problem Statement**

Audit data can expose sensitive patient information.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 279: Patient information can be returned to users who should only see appointments.

**Problem Statement**

Patient information can be returned to users who should only see appointments.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 280: Billing information can be returned to users who should only see patient demographics.

**Problem Statement**

Billing information can be returned to users who should only see patient demographics.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 281: Prescription information can be returned to users outside the care team.

**Problem Statement**

Prescription information can be returned to users outside the care team.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 282: Report endpoints return broad data without checking purpose.

**Problem Statement**

Report endpoints return broad data without checking purpose.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 283: Error handling hides validation mistakes during development.

**Problem Statement**

Error handling hides validation mistakes during development.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 284: Generic exception throwing makes error responses difficult to classify.

**Problem Statement**

Generic exception throwing makes error responses difficult to classify.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 285: Some methods catch errors and continue as if successful.

**Problem Statement**

Some methods catch errors and continue as if successful.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 286: Some operations do not log failures at all.

**Problem Statement**

Some operations do not log failures at all.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 287: Some log messages do not contain identifiers needed for tracing.

**Problem Statement**

Some log messages do not contain identifiers needed for tracing.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 288: Some API responses are inconsistent between similar actions.

**Problem Statement**

Some API responses are inconsistent between similar actions.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 289: Some endpoints return success without verifying the database changed.

**Problem Statement**

Some endpoints return success without verifying the database changed.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 290: Some update operations do not protect against lost updates.

**Problem Statement**

Some update operations do not protect against lost updates.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 291: Some user actions can overwrite another user's recent changes.

**Problem Statement**

Some user actions can overwrite another user's recent changes.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 292: Some screens do not warn when leaving with unsaved changes.

**Problem Statement**

Some screens do not warn when leaving with unsaved changes.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 293: Some forms reuse stale model data after a failed save.

**Problem Statement**

Some forms reuse stale model data after a failed save.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 294: Some screens show cached data after mutation.

**Problem Statement**

Some screens show cached data after mutation.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 295: Some list refreshes happen before the save operation completes.

**Problem Statement**

Some list refreshes happen before the save operation completes.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 296: Some validations rely on browser behaviour and fail in API clients.

**Problem Statement**

Some validations rely on browser behaviour and fail in API clients.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 297: Some numeric values are passed as strings and handled inconsistently.

**Problem Statement**

Some numeric values are passed as strings and handled inconsistently.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 298: Medium additional realistic issue #148 needs to be reproduced, diagnosed, and fixed without breaking existing workflows.

**Problem Statement**

Medium additional realistic issue #148 needs to be reproduced, diagnosed, and fixed without breaking existing workflows.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 299: Medium additional realistic issue #149 needs to be reproduced, diagnosed, and fixed without breaking existing workflows.

**Problem Statement**

Medium additional realistic issue #149 needs to be reproduced, diagnosed, and fixed without breaking existing workflows.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 300: Medium additional realistic issue #150 needs to be reproduced, diagnosed, and fixed without breaking existing workflows.

**Problem Statement**

Medium additional realistic issue #150 needs to be reproduced, diagnosed, and fixed without breaking existing workflows.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---


# Hard Tickets

### Ticket 301: Design a safe booking flow that prevents double booking under real concurrent traffic.

**Problem Statement**

Design a safe booking flow that prevents double booking under real concurrent traffic.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 302: Introduce a consistent status transition model for appointments, bills, prescriptions, and admissions.

**Problem Statement**

Introduce a consistent status transition model for appointments, bills, prescriptions, and admissions.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 303: Redesign billing so totals, discounts, tax, insurance, and payments cannot become inconsistent.

**Problem Statement**

Redesign billing so totals, discounts, tax, insurance, and payments cannot become inconsistent.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 304: Implement a secure authentication flow with proper token lifetime, validation, refresh, and revocation.

**Problem Statement**

Implement a secure authentication flow with proper token lifetime, validation, refresh, and revocation.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 305: Design authorization so each role can perform only allowed actions even through direct API calls.

**Problem Statement**

Design authorization so each role can perform only allowed actions even through direct API calls.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 306: Refactor the application so patient privacy is protected across all read and report operations.

**Problem Statement**

Refactor the application so patient privacy is protected across all read and report operations.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 307: Introduce an audit trail that reliably records sensitive changes without leaking unnecessary data.

**Problem Statement**

Introduce an audit trail that reliably records sensitive changes without leaking unnecessary data.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 308: Make appointment availability accurate for overlapping time ranges and configurable doctor durations.

**Problem Statement**

Make appointment availability accurate for overlapping time ranges and configurable doctor durations.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 309: Make bed allocation safe when many admissions happen at the same time.

**Problem Statement**

Make bed allocation safe when many admissions happen at the same time.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 310: Create a prescription safety workflow that blocks allergy conflicts and discontinued medicines.

**Problem Statement**

Create a prescription safety workflow that blocks allergy conflicts and discontinued medicines.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 311: Create an insurance rule engine that applies coverage only to eligible bill items.

**Problem Statement**

Create an insurance rule engine that applies coverage only to eligible bill items.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 312: Refactor reporting so large datasets do not block normal user requests.

**Problem Statement**

Refactor reporting so large datasets do not block normal user requests.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 313: Move long-running reports into a background process with trackable status.

**Problem Statement**

Move long-running reports into a background process with trackable status.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 314: Introduce a safe dynamic search, filter, sort, and pagination model.

**Problem Statement**

Introduce a safe dynamic search, filter, sort, and pagination model.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 315: Replace unsafe query-building while keeping flexible search behaviour.

**Problem Statement**

Replace unsafe query-building while keeping flexible search behaviour.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 316: Create a database constraint strategy that supports the real business rules.

**Problem Statement**

Create a database constraint strategy that supports the real business rules.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 317: Add missing relationships without breaking existing legacy records.

**Problem Statement**

Add missing relationships without breaking existing legacy records.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 318: Normalize status values without breaking existing screens and reports.

**Problem Statement**

Normalize status values without breaking existing screens and reports.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 319: Refactor duplicate validation rules into a maintainable validation approach.

**Problem Statement**

Refactor duplicate validation rules into a maintainable validation approach.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 320: Create consistent error handling across all user flows and API responses.

**Problem Statement**

Create consistent error handling across all user flows and API responses.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 321: Create a consistent date-time policy for appointments, reports, billing, and audit entries.

**Problem Statement**

Create a consistent date-time policy for appointments, reports, billing, and audit entries.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 322: Fix lost-update problems when multiple users edit the same patient record.

**Problem Statement**

Fix lost-update problems when multiple users edit the same patient record.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 323: Make payment operations idempotent so retries do not duplicate payment.

**Problem Statement**

Make payment operations idempotent so retries do not duplicate payment.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 324: Make booking operations idempotent so browser refresh does not duplicate appointments.

**Problem Statement**

Make booking operations idempotent so browser refresh does not duplicate appointments.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 325: Design a secure way to store and rotate application secrets.

**Problem Statement**

Design a secure way to store and rotate application secrets.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 326: Reduce dashboard load while keeping numbers accurate enough for business use.

**Problem Statement**

Reduce dashboard load while keeping numbers accurate enough for business use.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 327: Introduce caching where useful without showing stale sensitive data.

**Problem Statement**

Introduce caching where useful without showing stale sensitive data.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 328: Design cache invalidation for patient counts, revenue, and appointment summaries.

**Problem Statement**

Design cache invalidation for patient counts, revenue, and appointment summaries.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 329: Refactor mixed data access patterns into a predictable data access strategy.

**Problem Statement**

Refactor mixed data access patterns into a predictable data access strategy.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 330: Remove direct database access from request-handling code without breaking behaviour.

**Problem Statement**

Remove direct database access from request-handling code without breaking behaviour.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 331: Split overloaded services into smaller units without changing external APIs.

**Problem Statement**

Split overloaded services into smaller units without changing external APIs.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 332: Replace hardcoded business values with configurable rules.

**Problem Statement**

Replace hardcoded business values with configurable rules.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 333: Create a migration path from free-text status fields to controlled status records.

**Problem Statement**

Create a migration path from free-text status fields to controlled status records.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 334: Design a permission model that can grow beyond the current four roles.

**Problem Statement**

Design a permission model that can grow beyond the current four roles.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 335: Prevent sensitive data exposure in logs, errors, browser storage, and reports.

**Problem Statement**

Prevent sensitive data exposure in logs, errors, browser storage, and reports.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 336: Refactor the frontend authentication flow so route protection cannot be bypassed.

**Problem Statement**

Refactor the frontend authentication flow so route protection cannot be bypassed.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 337: Create a reliable frontend state update strategy after create, update, delete, and payment actions.

**Problem Statement**

Create a reliable frontend state update strategy after create, update, delete, and payment actions.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 338: Refactor repeated frontend request logic into reusable services without hiding errors.

**Problem Statement**

Refactor repeated frontend request logic into reusable services without hiding errors.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 339: Implement safe request cancellation for search and changing detail pages.

**Problem Statement**

Implement safe request cancellation for search and changing detail pages.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 340: Replace dashboard polling with a safer refresh strategy.

**Problem Statement**

Replace dashboard polling with a safer refresh strategy.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 341: Create consistent frontend validation that matches server-side rules.

**Problem Statement**

Create consistent frontend validation that matches server-side rules.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 342: Design a safe way to show validation errors from the API in forms.

**Problem Statement**

Design a safe way to show validation errors from the API in forms.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 343: Refactor billing UI so it cannot submit invalid or stale totals.

**Problem Statement**

Refactor billing UI so it cannot submit invalid or stale totals.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 344: Refactor appointment booking UI so it handles unavailable slots, retries, and time zones.

**Problem Statement**

Refactor appointment booking UI so it handles unavailable slots, retries, and time zones.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 345: Create an integration testing strategy for critical patient, billing, and appointment flows.

**Problem Statement**

Create an integration testing strategy for critical patient, billing, and appointment flows.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 346: Create tests that expose concurrency defects in booking and bed allocation.

**Problem Statement**

Create tests that expose concurrency defects in booking and bed allocation.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 347: Create tests that expose duplicate payment and idempotency defects.

**Problem Statement**

Create tests that expose duplicate payment and idempotency defects.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 348: Create tests that prove deleted or restricted data is not visible.

**Problem Statement**

Create tests that prove deleted or restricted data is not visible.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 349: Add observability so production failures can be traced across request, database, and user action.

**Problem Statement**

Add observability so production failures can be traced across request, database, and user action.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 350: Introduce health checks that validate database connectivity and critical dependencies.

**Problem Statement**

Introduce health checks that validate database connectivity and critical dependencies.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 351: Design a safe deployment strategy for schema changes that add constraints to dirty data.

**Problem Statement**

Design a safe deployment strategy for schema changes that add constraints to dirty data.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 352: Create a cleanup strategy for existing duplicate patients.

**Problem Statement**

Create a cleanup strategy for existing duplicate patients.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 353: Create a cleanup strategy for existing duplicate appointments.

**Problem Statement**

Create a cleanup strategy for existing duplicate appointments.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 354: Create a cleanup strategy for invalid bills and payments.

**Problem Statement**

Create a cleanup strategy for invalid bills and payments.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 355: Create a cleanup strategy for invalid admissions and bed occupancy.

**Problem Statement**

Create a cleanup strategy for invalid admissions and bed occupancy.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 356: Refactor report queries so they use indexes efficiently.

**Problem Statement**

Refactor report queries so they use indexes efficiently.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 357: Replace cursor-style report logic with set-based logic.

**Problem Statement**

Replace cursor-style report logic with set-based logic.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 358: Redesign age-based filtering so it is correct and efficient.

**Problem Statement**

Redesign age-based filtering so it is correct and efficient.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 359: Redesign date filtering so it includes the correct range and remains index-friendly.

**Problem Statement**

Redesign date filtering so it includes the correct range and remains index-friendly.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 360: Create an archival strategy for old appointments, bills, and audit logs.

**Problem Statement**

Create an archival strategy for old appointments, bills, and audit logs.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 361: Design a soft-delete strategy that is consistently applied across all reads and writes.

**Problem Statement**

Design a soft-delete strategy that is consistently applied across all reads and writes.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 362: Design restore behaviour for accidentally deleted patients.

**Problem Statement**

Design restore behaviour for accidentally deleted patients.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 363: Ensure deleting or deactivating doctors does not corrupt appointment history.

**Problem Statement**

Ensure deleting or deactivating doctors does not corrupt appointment history.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 364: Design a safe doctor deactivation workflow with future appointment handling.

**Problem Statement**

Design a safe doctor deactivation workflow with future appointment handling.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 365: Ensure patient deletion respects active admissions, future appointments, and unpaid bills.

**Problem Statement**

Ensure patient deletion respects active admissions, future appointments, and unpaid bills.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 366: Create a reliable discharge process that updates admission and bed state atomically.

**Problem Statement**

Create a reliable discharge process that updates admission and bed state atomically.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 367: Design a billing lock so paid bills cannot be edited while still allowing corrections.

**Problem Statement**

Design a billing lock so paid bills cannot be edited while still allowing corrections.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 368: Design a refund process instead of accepting negative payments.

**Problem Statement**

Design a refund process instead of accepting negative payments.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 369: Design a medicine discontinuation workflow that handles drafts and historical prescriptions.

**Problem Statement**

Design a medicine discontinuation workflow that handles drafts and historical prescriptions.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 370: Create a patient merge workflow for duplicate patient records.

**Problem Statement**

Create a patient merge workflow for duplicate patient records.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 371: Create a safe unique-patient rule that avoids blocking legitimate patients with similar details.

**Problem Statement**

Create a safe unique-patient rule that avoids blocking legitimate patients with similar details.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 372: Design a data access boundary that prevents controllers from exposing internal entities.

**Problem Statement**

Design a data access boundary that prevents controllers from exposing internal entities.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 373: Create API response contracts that can evolve without breaking frontend screens.

**Problem Statement**

Create API response contracts that can evolve without breaking frontend screens.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 374: Introduce API versioning for high-risk endpoints.

**Problem Statement**

Introduce API versioning for high-risk endpoints.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 375: Design consistent validation and error contracts for all endpoints.

**Problem Statement**

Design consistent validation and error contracts for all endpoints.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 376: Refactor exception handling so operational errors, validation errors, and unknown errors are separated.

**Problem Statement**

Refactor exception handling so operational errors, validation errors, and unknown errors are separated.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 377: Create a transaction boundary strategy for multi-step operations.

**Problem Statement**

Create a transaction boundary strategy for multi-step operations.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 378: Ensure all commands inside a transaction use the same connection and transaction.

**Problem Statement**

Ensure all commands inside a transaction use the same connection and transaction.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 379: Design retry behaviour for transient database failures without duplicating writes.

**Problem Statement**

Design retry behaviour for transient database failures without duplicating writes.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 380: Create a security review of every endpoint and close direct-call bypasses.

**Problem Statement**

Create a security review of every endpoint and close direct-call bypasses.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 381: Create secure refresh-token rotation and reuse detection.

**Problem Statement**

Create secure refresh-token rotation and reuse detection.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 382: Create account lockout or throttling for repeated failed login attempts.

**Problem Statement**

Create account lockout or throttling for repeated failed login attempts.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 383: Implement rate limits for login, search, and high-cost reports.

**Problem Statement**

Implement rate limits for login, search, and high-cost reports.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 384: Design safe CORS configuration for local, test, and production environments.

**Problem Statement**

Design safe CORS configuration for local, test, and production environments.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 385: Replace local browser role trust with server-backed permission decisions.

**Problem Statement**

Replace local browser role trust with server-backed permission decisions.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 386: Create a safe session expiry experience that does not lose unsaved form data.

**Problem Statement**

Create a safe session expiry experience that does not lose unsaved form data.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 387: Create a global frontend error handling strategy.

**Problem Statement**

Create a global frontend error handling strategy.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 388: Create a global frontend loading and pending-request strategy.

**Problem Statement**

Create a global frontend loading and pending-request strategy.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 389: Create frontend route rules that handle authenticated, unauthenticated, and unauthorized states separately.

**Problem Statement**

Create frontend route rules that handle authenticated, unauthenticated, and unauthorized states separately.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 390: Create a frontend data model instead of using untyped objects everywhere.

**Problem Statement**

Create a frontend data model instead of using untyped objects everywhere.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 391: Refactor nested subscriptions into clearer observable flows.

**Problem Statement**

Refactor nested subscriptions into clearer observable flows.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 392: Ensure all component subscriptions are cleaned up safely.

**Problem Statement**

Ensure all component subscriptions are cleaned up safely.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 393: Design reusable table behaviour for paging, sorting, filtering, empty state, and errors.

**Problem Statement**

Design reusable table behaviour for paging, sorting, filtering, empty state, and errors.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 394: Create a safe search experience that debounces, cancels stale requests, and handles ordering.

**Problem Statement**

Create a safe search experience that debounces, cancels stale requests, and handles ordering.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 395: Create a form dirty-checking strategy for patient, billing, and appointment screens.

**Problem Statement**

Create a form dirty-checking strategy for patient, billing, and appointment screens.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 396: Create a consistent currency and decimal precision policy.

**Problem Statement**

Create a consistent currency and decimal precision policy.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 397: Create a consistent mobile and email normalization policy.

**Problem Statement**

Create a consistent mobile and email normalization policy.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 398: Design a domain rule for emergency admissions that bypasses normal insurance checks safely.

**Problem Statement**

Design a domain rule for emergency admissions that bypasses normal insurance checks safely.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 399: Create a permission-aware dashboard where different roles see different data.

**Problem Statement**

Create a permission-aware dashboard where different roles see different data.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 400: Create a reporting permission model for financial and patient data.

**Problem Statement**

Create a reporting permission model for financial and patient data.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 401: Design a secure audit viewer that hides sensitive fields based on role.

**Problem Statement**

Design a secure audit viewer that hides sensitive fields based on role.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 402: Create a patient consent or access-reason workflow for sensitive patient views.

**Problem Statement**

Create a patient consent or access-reason workflow for sensitive patient views.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 403: Design data masking for mobile, email, and insurance numbers where appropriate.

**Problem Statement**

Design data masking for mobile, email, and insurance numbers where appropriate.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 404: Create a strategy for preventing accidental mass data exposure through list endpoints.

**Problem Statement**

Create a strategy for preventing accidental mass data exposure through list endpoints.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 405: Create a secure file-upload workflow for patient documents.

**Problem Statement**

Create a secure file-upload workflow for patient documents.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 406: Create streaming upload/download behaviour for large files.

**Problem Statement**

Create streaming upload/download behaviour for large files.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 407: Add malware/type/size checks for uploaded patient documents.

**Problem Statement**

Add malware/type/size checks for uploaded patient documents.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 408: Design safe storage naming so uploaded files cannot overwrite or reveal other files.

**Problem Statement**

Design safe storage naming so uploaded files cannot overwrite or reveal other files.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 409: Create a background notification workflow for appointment reminders.

**Problem Statement**

Create a background notification workflow for appointment reminders.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 410: Make notification sending resilient without blocking appointment booking.

**Problem Statement**

Make notification sending resilient without blocking appointment booking.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 411: Introduce an outbox-style pattern for important side effects.

**Problem Statement**

Introduce an outbox-style pattern for important side effects.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 412: Design recovery behaviour when side effects fail after database save.

**Problem Statement**

Design recovery behaviour when side effects fail after database save.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 413: Refactor patient creation so audit, validation, duplicate checks, and persistence are coordinated cleanly.

**Problem Statement**

Refactor patient creation so audit, validation, duplicate checks, and persistence are coordinated cleanly.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 414: Refactor appointment booking so availability, validation, persistence, and notification are coordinated cleanly.

**Problem Statement**

Refactor appointment booking so availability, validation, persistence, and notification are coordinated cleanly.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 415: Refactor billing so pricing, insurance, tax, payment, and audit are coordinated cleanly.

**Problem Statement**

Refactor billing so pricing, insurance, tax, payment, and audit are coordinated cleanly.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 416: Refactor admission so bed allocation, patient status, and audit are coordinated cleanly.

**Problem Statement**

Refactor admission so bed allocation, patient status, and audit are coordinated cleanly.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 417: Create a layered architecture that still allows pragmatic use of EF Core and Dapper.

**Problem Statement**

Create a layered architecture that still allows pragmatic use of EF Core and Dapper.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 418: Decide which legacy stored procedures should remain and which should move to application code.

**Problem Statement**

Decide which legacy stored procedures should remain and which should move to application code.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 419: Create a migration plan away from unsafe legacy helper methods.

**Problem Statement**

Create a migration plan away from unsafe legacy helper methods.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 420: Create a backwards-compatible contract for existing screens while improving backend safety.

**Problem Statement**

Create a backwards-compatible contract for existing screens while improving backend safety.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 421: Design feature flags for risky refactors.

**Problem Statement**

Design feature flags for risky refactors.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 422: Design a rollback plan for failed deployment of billing changes.

**Problem Statement**

Design a rollback plan for failed deployment of billing changes.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 423: Design a rollback plan for failed deployment of appointment changes.

**Problem Statement**

Design a rollback plan for failed deployment of appointment changes.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 424: Create database indexes based on actual access patterns rather than guessing.

**Problem Statement**

Create database indexes based on actual access patterns rather than guessing.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 425: Measure and improve worst-case patient search performance.

**Problem Statement**

Measure and improve worst-case patient search performance.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 426: Measure and improve dashboard response time under large data volume.

**Problem Statement**

Measure and improve dashboard response time under large data volume.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 427: Measure and improve report response time for one year of data.

**Problem Statement**

Measure and improve report response time for one year of data.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 428: Create load-test scenarios for booking, search, dashboard, and billing.

**Problem Statement**

Create load-test scenarios for booking, search, dashboard, and billing.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 429: Create a production incident checklist for duplicate booking.

**Problem Statement**

Create a production incident checklist for duplicate booking.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 430: Create a production incident checklist for duplicate payment.

**Problem Statement**

Create a production incident checklist for duplicate payment.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 431: Create a production incident checklist for wrong patient data exposure.

**Problem Statement**

Create a production incident checklist for wrong patient data exposure.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 432: Add correlation identifiers across frontend, API, logs, and database audit.

**Problem Statement**

Add correlation identifiers across frontend, API, logs, and database audit.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 433: Create structured logging instead of plain console messages.

**Problem Statement**

Create structured logging instead of plain console messages.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 434: Classify logs into debug, information, warning, and error correctly.

**Problem Statement**

Classify logs into debug, information, warning, and error correctly.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 435: Prevent sensitive values from appearing in structured logs.

**Problem Statement**

Prevent sensitive values from appearing in structured logs.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 436: Design a monitoring alert for repeated failed payments.

**Problem Statement**

Design a monitoring alert for repeated failed payments.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 437: Design a monitoring alert for repeated failed bookings.

**Problem Statement**

Design a monitoring alert for repeated failed bookings.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 438: Design a monitoring alert for slow dashboard or report endpoints.

**Problem Statement**

Design a monitoring alert for slow dashboard or report endpoints.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 439: Create a data-retention policy for audit, appointments, reports, and tokens.

**Problem Statement**

Create a data-retention policy for audit, appointments, reports, and tokens.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 440: Create a token cleanup job that safely removes expired records.

**Problem Statement**

Create a token cleanup job that safely removes expired records.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 441: Create a report snapshot strategy so old reports remain stable after data changes.

**Problem Statement**

Create a report snapshot strategy so old reports remain stable after data changes.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 442: Create a security hardening checklist for the whole application.

**Problem Statement**

Create a security hardening checklist for the whole application.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 443: Create a refactoring roadmap that improves the system without rewriting everything.

**Problem Statement**

Create a refactoring roadmap that improves the system without rewriting everything.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 444: Create an end-to-end workflow test that covers patient creation, appointment, bill, payment, and report.

**Problem Statement**

Create an end-to-end workflow test that covers patient creation, appointment, bill, payment, and report.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 445: Create an end-to-end workflow test that covers admission, bed allocation, discharge, and billing.

**Problem Statement**

Create an end-to-end workflow test that covers admission, bed allocation, discharge, and billing.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 446: Create an end-to-end workflow test that covers prescription safety and patient allergy validation.

**Problem Statement**

Create an end-to-end workflow test that covers prescription safety and patient allergy validation.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 447: Create a final production-readiness review and fix all remaining high-risk behaviours.

**Problem Statement**

Create a final production-readiness review and fix all remaining high-risk behaviours.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 448: Hard additional realistic issue #148 needs to be reproduced, diagnosed, and fixed without breaking existing workflows.

**Problem Statement**

Hard additional realistic issue #148 needs to be reproduced, diagnosed, and fixed without breaking existing workflows.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 449: Hard additional realistic issue #149 needs to be reproduced, diagnosed, and fixed without breaking existing workflows.

**Problem Statement**

Hard additional realistic issue #149 needs to be reproduced, diagnosed, and fixed without breaking existing workflows.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---

### Ticket 450: Hard additional realistic issue #150 needs to be reproduced, diagnosed, and fixed without breaking existing workflows.

**Problem Statement**

Hard additional realistic issue #150 needs to be reproduced, diagnosed, and fixed without breaking existing workflows.

**Expected Result**

The system should handle this case correctly, safely, and consistently without creating side effects in other workflows.

<details>
<summary>Hint 1</summary>

Reproduce the behaviour first. Try using both the visible screen and a direct request where possible.

</details>

<details>
<summary>Hint 2</summary>

Check whether the current behaviour is caused by missing validation, trusting user input, inconsistent rules, or incorrect state changes.

</details>

<details>
<summary>Hint 3</summary>

After fixing it, test at least one success case, one failure case, and one edge case.

</details>

---
