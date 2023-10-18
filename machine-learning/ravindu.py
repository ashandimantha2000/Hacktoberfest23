import argparse
import io
import os
import numpy as np
from PIL import Image
import cv2
import torch
from flask import Flask, request

app = Flask(__name__)

DETECTION_URL = "/v1/object-detection/yolov5"

UPLOAD_FOLDER = 'uploads'
app.config['UPLOAD_FOLDER'] = UPLOAD_FOLDER


@app.route(DETECTION_URL, methods=["POST"])
def predict():
    if not request.method == "POST":
        return

    if request.files.get("video"):
        video_file = request.files["video"]

        if video_file:
            filename = 'video.mp4'
            video_file.save(os.path.join(app.config['UPLOAD_FOLDER'], filename))
            
            video_path = 'uploads/video.mp4'
            cap = cv2.VideoCapture(video_path)

            detected_classes = []  # List to store detected classes

            while cap.isOpened():
                ret, frame = cap.read()
                
                if not ret:
                    break

                # Inference
                results = model(frame)

                # Get classes
                classes = results.pandas().xyxy[0]['name'].tolist()

                # Add classes to the list
                detected_classes.extend(classes)

            cap.release()
            cv2.destroyAllWindows()

            # Print the array of detected classes
            return (detected_classes)


if __name__ == "__main__":
    parser = argparse.ArgumentParser(description="Flask api exposing yolov5 model")
    parser.add_argument("--port", default=5000, type=int, help="port number")
    parser.add_argument('--model', default='yolov5s', help='model to run, i.e. --model yolov5s')
    args = parser.parse_args()

    model = torch.hub.load("ultralytics/yolov5", "custom", args.model)
    app.run(host="0.0.0.0", port=args.port)  # debug=True causes Restarting with stat
