# Variables
IMAGE_NAME := employee-web-portal-api
TAG := v1
BUILD_VERSION := 1.0.0
BUILD_CONFIGURATION := Release
DOCKERFILE := src/UserPortal.API/Dockerfile
CONTAINER_NAME := employee-web-portal-api-container

# Colors for output
CYAN := \\033[0;36m
GREEN := \\033[0;32m
RESET := \\033[0m

.PHONY: help build run stop clean logs shell

# Default target
help:
	@echo -e "$(CYAN)Available targets:$(RESET)"
	@echo -e "  $(GREEN)build$(RESET)          - Build the Docker image"
	@echo -e "  $(GREEN)run$(RESET)            - Run the Docker container"
	@echo -e "  $(GREEN)stop$(RESET)           - Stop the Docker container"
	@echo -e "  $(GREEN)clean$(RESET)          - Remove the Docker image and container"
	@echo -e "  $(GREEN)logs$(RESET)           - View container logs"
	@echo -e "  $(GREEN)shell$(RESET)          - Open a shell in the running container"
	@echo ""
	@echo -e "$(CYAN)Variables:$(RESET)"
	@echo "  IMAGE_NAME         = $(IMAGE_NAME)"
	@echo "  TAG                = $(TAG)"
	@echo "  BUILD_VERSION      = $(BUILD_VERSION)"
	@echo "  BUILD_CONFIGURATION = $(BUILD_CONFIGURATION)"

# Build the Docker image
build:
	@echo -e "$(CYAN)Building Docker image $(IMAGE_NAME):$(TAG)...$(RESET)"
	docker build \
		--build-arg BUILD_CONFIGURATION=$(BUILD_CONFIGURATION) \
		--build-arg BUILD_VERSION=$(BUILD_VERSION) \
		-t $(IMAGE_NAME):$(TAG) \
		-f $(DOCKERFILE) \
		.
	@echo -e "$(GREEN)Build complete!$(RESET)"

# Run the Docker container
run:
	@echo -e "$(CYAN)Running Docker container...$(RESET)"
	docker run -d \
		--name $(CONTAINER_NAME) \
		-p 8080:8080 \
		-p 8081:8081 \
		$(IMAGE_NAME):$(TAG)
	@echo -e "$(GREEN)Container started! Access the API at http://localhost:8080$(RESET)"

# Stop the Docker container
stop:
	@echo -e "$(CYAN)Stopping Docker container...$(RESET)"
	-docker stop $(CONTAINER_NAME)
	-docker rm $(CONTAINER_NAME)
	@echo -e "$(GREEN)Container stopped and removed!$(RESET)"

# Remove Docker image and container
clean: stop
	@echo -e "$(CYAN)Removing Docker image...$(RESET)"
	-docker rmi $(IMAGE_NAME):$(TAG)
	@echo -e "$(GREEN)Cleanup complete!$(RESET)"

# View container logs
logs:
	@docker logs -f $(CONTAINER_NAME)

# Open a shell in the running container
shell:
	@docker exec -it $(CONTAINER_NAME) /bin/bash

# Build and run
up: build run

# Rebuild (clean and build)
rebuild: clean build
