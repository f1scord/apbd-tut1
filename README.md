# apbd-tut1

1. When does Git perform a fast-forward and when is a merge commit created?
The fast-forward merge is created when there are no newer changes on the main branch from the commit where the secondary branch was created, then git just puts the checked out branch commits on top of the main. The merge commit is created when both branches arleady have new commits pushed and then git creates a new merge commit so both branches history can be recovered after the merge.

2. What is the practical difference between merge and rebase?
Practical difference is that merge combines the changes from the other branch into single branch and the rebase moves the commit point where checked out branch was divided to the newest one from the main branch.

3. How was the conflict resolved in your repository?
I choose the version from the checkout branch feature-conflict and commited it to the main thus the conflict was resolved since no logic was touched I just choose the word I like more.