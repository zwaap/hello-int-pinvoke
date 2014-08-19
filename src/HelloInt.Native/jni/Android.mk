LOCAL_PATH := $(call my-dir)



include $(CLEAR_VARS)



LOCAL_MODULE    := hello_int

LOCAL_SRC_FILES := hello_int_exports.cpp



include $(BUILD_SHARED_LIBRARY)
