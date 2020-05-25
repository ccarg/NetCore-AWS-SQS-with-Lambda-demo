AWS CLI
https://aws.amazon.com/cli/

AWS Toolkit for Visual Studio
https://aws.amazon.com/visualstudio/

# IAM
 - Create User 
 - For SQS, Lambda and VS deployment cerate group with policies:
	SQS FullAccess
	S3 FullAccess
	IAM FullAccess
	Lambda FullAccess
	CloudFormation FullAccess
- Roles, create role (name role-lambda-test-example):
	Lambda
		SQS FullAccess
		AwsLambdaBasicExecutionRole
- Copy access and secret keys
- Set aws profile with awscli: cmd aws credentials 

# SQS
- Create AWS SQS 
- Create netCore project and install:
	install-package AWSSDK.SQS
	install-package AWSSDK.Extensions.NETCore.Setup
- Add in apsettings.json
  "AWS": {
    "Profile": "default",
    "Region": "us-east-1"
  }
- Startup.cs             
	services.AddAWSService<IAmazonSQS>(Configuration.GetAWSOptions());

# Lambda
- Add new project using: [AWS Lambda Project C#] template with Simple SQS Function blueprint
- Right click on the project and select: Publish to AWS Lambdas
- Give Function name, click next
- Select Profile and region
- Select Lambda Role: role-lambda-test-example
- Click upload to complete deployment
- On AWS console, go to lambdas
- Select new function 
- Click add trigger
- Select SQS queue

# Testing
- Submit SQS message using Postman
- Open Lambda
- Click Monitoring tab and [View logs in Cloud Watch]