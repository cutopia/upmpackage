# upmpackage
Steps:
1. Create a new unity project (I'm using Unity 2018.3.something).
2. Edit the manfiest.json under Packages directory with a text editor.
3. Add ["com.cutopia.helloworld": "https://github.com/cutopia/upmpackage.git",] (the string between the []) to the top of the dependencies list.
4. Save your manifest.json
5. Go back to Unity editor which will trigger some activity as it imports the repo.
6. Notice that Hello World appears in the log. This shows the code from the package is being run successfully.
