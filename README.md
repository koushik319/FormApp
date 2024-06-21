
 *** FRONTEND ***
  
* All the front code is working 
* If we click on NewSubmission we can submit the form
* If we click on ViewSubmssion we get the latest submitted data


   *** BACKEND ***

 * Created a backend file named Server.js where we have all the three endpoints

* /ping - A GET request that always returns True
* /submit - A POST request with parameters "name", "email", "phone", "github_link" and "stopwatch_time"
* /read - A GET request with query parameter "index" which is a 0-index for reading the (index+1)th form submission.

    *** TO RUN THE BACKEND FILE ***
  * Follow this command
  *  node server.js
 
  
