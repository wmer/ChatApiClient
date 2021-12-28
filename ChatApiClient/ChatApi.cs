using ChatApiClient.Models;
using ManyHelpers.API;
using ManyHelpers.Files;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApiClient {
    public class ChatApi {
        private string _baseUrl = "https://api.chat-api.com/instance";
        private string _instnceId;
        private string _token;
        private CosumingHelper _cosumingHelper;

        public ChatApi(string instanceId, string token) {
            _instnceId = instanceId;
            _token = token;
            _cosumingHelper = new CosumingHelper(_baseUrl)
                                            .AddcontentType();
        }
        public async Task<SenderResponse> SendMessageOrFileAsync(Message message) {
            var resposta = new SenderResponse();
            if (string.IsNullOrEmpty(message.filename)) {
                resposta = await SendMessageAsync(message);
            } else {
                resposta = await SendFileAsync(message);
            }

            return resposta;
        }


        public async Task<SenderResponse> SendMessageAsync(string phone, string message, string file = null) {
            var resposta = new SenderResponse();
            var msg = new Message {
                phone = phone,
                body = message
            };

            if (!string.IsNullOrEmpty(file) && File.Exists(file)) {
                var fileInfo = new FileInfo(file);
                var base64 = FileHelper.GetBase64String(file);
                var mime = FileHelper.GetMimeFromFile(file);
                msg.body = $"data:{mime};base64,{base64}";
                msg.filename = fileInfo.Name;
                msg.caption = message;
            }

            resposta = await SendMessageOrFileAsync(msg);
            return resposta;
        }


        public async Task<SenderResponse> SendMessageAsync(Message message) {
            var resposta = await _cosumingHelper.PostAsync<Message, SenderResponse>($"{_instnceId}/message?token={_token}", message);
            return resposta.result;
        }

        public async Task<SenderResponse> SendFileAsync(Message message) {
            var resposta = await _cosumingHelper.PostAsync<Message, SenderResponse>($"{_instnceId}/sendFile?token={_token}", message);
            return resposta.result;
        }

        public async Task<Messages> GetMessages() {
            var resposta = await _cosumingHelper.GetAssync<Messages>($"{_instnceId}/messages?token={_token}");
            return resposta.result;
        }
    }
}
