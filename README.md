### **GitHub Repository Creation Checklist**
:cyclone: DRAFT :cyclone:

#### 1. **Repository Setup**
   - [ ] **Repository Name:** Choose a clear, descriptive name for the repository. _The name should **not** include version numbers or similar identifiers_ 
   - [ ] **Description:** Add a brief description of the project, summarizing its purpose and functionality.
   - [ ] **Repository Type:**
     - [ ] ~~Public~~ - _All SBS repos must be private unless specifically approved with VP consent_ 
     - [ ] Private 
   - [ ] **Initialize with README:** Select this option to include a README file, which provides an overview of the project.
   - [ ] **.gitignore File:** Add a `.gitignore` template appropriate for your project (e.g., Python, Node.js, etc.).
   - [ ] **License:** Choose an appropriate license for your project - For all SBS Projects, this should be a link to the appropriate EULA which should be stored in GitHub

This is a great resource for setting up a repo. It is designed for open source public repos, so we don't need to follow all of the guidance, 
but the information is well laid out. https://opensource.creativecommons.org/contributing-code/github-repo-guidelines/

#### 2. **Repository Structure**
   - [ ] **Create Essential Directories:**
     - [ ] `src/` for source code.
     - [ ] `tests/` for test cases.
     - [ ] `docs/` for documentation.
     - [ ] `config/` for configuration files.
     - [ ] `scripts/` for automation scripts (e.g., build, deployment).
   - [ ] **Create Initial Files:**
     - [ ] `README.md` based on [BLANK_README.md](https://github.com/spatialbiz/Template_ReadMe/blob/170cfd20c77c249302891e3d91589cfc4daaa570/BLANK_README.md)
     - [ ] `.gitignore` with appropriate patterns for your project.
     - [ ] `LICENSE` file. **TODO: Link to EULA**
     - [ ] `CONTRIBUTING.md` to guide contributors.
     - [ ] `CHANGELOG.md` to track changes over time.
     - [ ] `Dockerfile` if using Docker for containerization.
     - [ ] `Makefile` or build script if applicable.

#### 3. **Version Control Practices**
   - [ ] **Branch Protection Rules:**
     - [ ] [Set up branch protection for the `main` branch.](https://docs.github.com/en/repositories/configuring-branches-and-merges-in-your-repository/managing-protected-branches/about-protected-branches#require-pull-request-reviews-before-merging)
     - [ ] [Require pull request reviews before merging.](https://docs.github.com/en/repositories/configuring-branches-and-merges-in-your-repository/managing-protected-branches/about-protected-branches#require-pull-request-reviews-before-merging)
     - [ ] Enforce linear history and restrict force pushes.
     - [ ] Require status checks to pass before merging.
   - [ ] **Branching Strategy:**
     - [ ] Document the branching strategy used: Use one of the recomended approaches listed [here](https://spatialbiz.atlassian.net/wiki/spaces/SD/pages/35520532/Git+Branching+Recommendations)
   - [ ] **Commit Message Guidelines:**
     - [ ] Establish clear guidelines for commit messages (e.g., Conventional Commits).
     - [ ] Ensure commit messages are descriptive and concise.

#### 4. **Collaboration and Contribution**
   - [ ] **Set Up Collaborators:** Add team members or collaborators with appropriate permissions.
   - [ ] **Issue Templates:** Create issue templates for bug reports, feature requests, and other common issues.
   - [ ] **Pull Request Template:** Create a pull request template to guide contributors through the process.
   - [ ] **TODO: Contributor Guidelines:** Include clear guidelines in `CONTRIBUTING.md` on how to contribute to the project.
   - [ ] **Set Up GitHub Actions If using:** Implement CI/CD pipelines using GitHub Actions for automated testing, building, and deployment.

#### 5. **Documentation**
   - [ ] **Detailed README:**
     - [ ] Add links to related resources and documentation.
     - [ ] Provide contact information for the project maintainers.
   - [ ] **Additional Documentation:**
     - [ ] `docs/` directory for detailed project documentation (e.g., API docs, architecture diagrams).

#### 6. **Security**
   - [ ] **Dependabot Alerts:** Enable Dependabot for automatic dependency scanning and updates.
   - [ ] **Security Policy:** Add a `SECURITY.md` file with instructions for reporting vulnerabilities.
   - [ ] **Secrets Management:** Use GitHub (or AWS) Secrets for managing sensitive data in your workflows.
   - [ ] **Code Scanning:** Enable GitHub CodeQL identify vulnerabilities.

#### 7. **Project Related**
   - [ ] **Labels:** Verify labels use **TODO:** SBS Template
   - [ ] Confluence or GitHub Pages for comprehensive project documentation.
   - [ ] **Project Board:** Set up a GitHub Project Board for task tracking and project management. **TODO:** Include link to template

#### 8. **Repository Settings**
   - [ ] **Repository Settings:**
     - [ ] Set up default branch.
     - [ ] Enable or disable issues and pull requests based on project needs.
     - [ ] Adjust repository visibility and permissions as required.
   - [ ] **Webhooks and Integrations:** Set up webhooks or integrations with other tools (e.g., Teams, AWS Services).

#### 9. **Final Review**
   - [ ] **Pre-Launch Review:** Double-check that all necessary files, templates, and settings are in place.
   - [ ] **Invite Collaborators:** Ensure all team members have access and understand the project setup.
   - [ ] **Initial Commit:** Make an initial commit with the setup files and push to the remote repository.



<!-- Improved compatibility of back to top link -->
<a id="readme-top"></a>


<!-- TOP LINKS -->
<!--
*** Optional markdown "reference style" links for readability, examples at bottom of page.
*** https://www.markdownguide.org/basic-syntax/#reference-style-links
-->


  <p align="center">
    <a href="https://github.com/spatialbiz/repo_name/projects/">Project</a>
    ·
    <a href="https://spatialbiz.atlassian.net/wiki/spaces/SD/pages/">Confluence</a>
    ·
    <a href="https://github.com/spatialbiz/repo_name/wiki">Wiki</a>
    ·
    <a href="#getting-started">Setup</a>
  </p>




<!-- LOGO AND PROJECT TITLE -->
<br />
<div align="center">
  <a href="https://www.spatialbiz.com/">
    <img src="https://spatialbiz.com/wp-content/uploads/2021/02/SBS_logo.png" alt="Logo" width="170" height="80">
  </a>

<h3 align="center">project_title</h3>

  <p align="center">
    project_description
    <br />
    <br />
    <a href="https://www.google.com/">Optional</a>
    ·
    <a href="https://www.bing.com/">Relevant</a>
    ·
    <a href="https://github.com/">Links</a>
  </p>
</div>



<!-- ABOUT THE PROJECT -->
## About The Project

Blank template to get started: To avoid retyping too much info. Do a search and replace with your text editor for the following: 
`repo_name`, `project_title`, `project_description`

A repo can have multiple `README.md` files in sub-directories that will be displayed in GitHub. 

<p align="right">(<a href="#readme-top">back to top</a>)</p>




### Technologies

* [.NET Framework][NET-Framework-Url]
* [.NET][NET-Url]
* [AutoCAD .NET API (.NET)](AutoCAD-Url)

<p align="right">(<a href="#readme-top">back to top</a>)</p>




<!-- GETTING STARTED -->
## Getting Started

This is an example of how you may give instructions on setting up your project locally.


<p align="right">(<a href="#readme-top">back to top</a>)</p>



### Environment Setup

* NuGet restore
    ```console
    dotnet restore -source -runtime -packages
    ```

<p align="right">(<a href="#readme-top">back to top</a>)</p>


### Building the Project

Provide instructions on how to build and run your project:

1. Go to the folder and build to check for errors:

    ```console
    dotnet build
    ```

2. Run your sample:

    ```console
    dotnet run
    ```

<p align="right">(<a href="#readme-top">back to top</a>)</p>



### Deployment

Provide instructions on how to deploy you applicaion.



<!-- CI/CD PIPELINES -->
## CI/CD Pipelines

This repository uses GitHub Actions workflows for deployment and job management. Each pipeline has dedicated documentation:

| Pipeline | Description | Trigger | Docs |
|----------|-------------|---------|------|
| **Deploy Handler** | Unified deployment for API across Dev, Staging, and DMZ | Push to `develop` / Manual / `repository_dispatch` | [📄 docs/DEPLOY_HANDLER.md](docs/DEPLOY_HANDLER.md) |
| **Deploy K8s Handler** | Deploy K8s Job container + optional job schedule sync | Push to `develop` (K8s paths) / Manual / `repository_dispatch` | [📄 docs/DEPLOY_K8S_HANDLER.md](docs/DEPLOY_K8S_HANDLER.md) |
| **Deploy K8s CronJob** | End-to-end process for Dev -> Test -> Release -> DMZ, including secrets and validation | Manual + Auto (by env) | [📄 docs/DEPLOY_K8S_JOB.md](docs/DEPLOY_K8S_JOB.md) |
| **Run K8s Job** | Manually trigger a K8s CronJob via SSM | Manual only | [📄 docs/RUN_K8S_JOB.md](docs/RUN_K8S_JOB.md) |

> **Note:** All deploy workflows use the shared reusable workflow from `spatialbiz/shared-services-action`. Job definitions are managed via the `K8S_JOB_OBJ` repository variable — see [Deploy K8s Handler docs](docs/DEPLOY_K8S_HANDLER.md#k8s_job_obj--job-configuration-variable) for details.


<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- DOCUMENTATION -->
## Documentation

| Topic | Description | Docs |
|-------|-------------|------|
| **Salesforce Test Data Endpoints** | Populate, query, and cleanup Salesforce sandbox test data via API | [📄 docs/SALESFORCE_TEST_DATA_ENDPOINTS.md](docs/SALESFORCE_TEST_DATA_ENDPOINTS.md) |

<p align="right">(<a href="#readme-top">back to top</a>)</p>
