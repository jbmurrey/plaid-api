1) Run plaid_api from the green start button
	(to execute apis click the drop down for that api and click try it out then hit execute. If it is a post request it will have a body you can paste in the json for the request)
2) execute the creds api and copy the response
3) paste the results of the cred api in the /auth api and execute
	(you should get an access token)
4) copy the transactionscreds.txt in the solution and paste the access token in the json and execute
	(it takes 20-30 seconds or 3-4 trys to get it to register who you are so execute the /transactions api a few times to get the results. It may come back as null or an empty array the first few times)
