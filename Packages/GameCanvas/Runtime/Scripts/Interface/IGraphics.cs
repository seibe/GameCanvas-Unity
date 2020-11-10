/*------------------------------------------------------------*/
// <summary>GameCanvas for Unity</summary>
// <author>Seibe TAKAHASHI</author>
// <remarks>
// (c) 2015-2020 Smart Device Programming.
// This software is released under the MIT License.
// http://opensource.org/licenses/mit-license.php
// </remarks>
/*------------------------------------------------------------*/
using System.ComponentModel;
using Unity.Mathematics;
using UnityEngine;

namespace GameCanvas
{
    public interface IGraphics
    {
        /// <summary>
        /// �w�i�F
        /// </summary>
        Color BackgroundColor { get; set; }

        /// <summary>
        /// �L�����o�X�O�ɕ\�������т̐F
        /// </summary>
        /// <remarks>
        /// <see cref="ChangeBorderColor"/> ���Ăяo�����ƂŕύX�ł��܂�
        /// </remarks>
        Color BorderColor { get; }

        /// <summary>
        /// �L�����o�X�𑜓x
        /// </summary>
        /// <remarks>
        /// <see cref="ChangeCanvasSize"/> ���Ăяo�����ƂŕύX�ł��܂�
        /// </remarks>
        int2 CanvasSize { get; }

        /// <summary>
        /// �~�̉𑜓x
        /// </summary>
        int CircleResolution { get; set; }

        /// <summary>
        /// �`��F
        /// </summary>
        Color Color { get; set; }

        /// <summary>
        /// ���݂̍��W�n�i�ϊ��s��j
        /// </summary>
        float2x3 CurrentCoordinate { get; set; }

        /// <summary>
        /// ���݂̃X�^�C��
        /// </summary>
        GcStyle CurrentStyle { get; set; }

        /// <summary>
        /// �[���X�N���[���𑜓x
        /// </summary>
        int2 DeviceScreenSize { get; }

        /// <summary>
        /// �t�H���g���
        /// </summary>
        GcFont Font { get; set; }

        /// <summary>
        /// �t�H���g�T�C�Y
        /// </summary>
        int FontSize { get; set; }

        /// <summary>
        /// �`���̒[�_�̌`��
        /// </summary>
        GcLineCap LineCap { get; set; }

        /// <summary>
        /// �`���̑���
        /// </summary>
        float LineWidth { get; set; }

        /// <summary>
        /// <see cref="PushCoordinate"/> �� <see cref="PopCoordinate"/> �������I�ɌĂяo�����X�R�[�v
        /// </summary>
        CoordianteScope CoordinateScope { get; }

        /// <summary>
        /// ��`�̃A���J�[�ʒu
        /// </summary>
        GcAnchor RectAnchor { get; set; }

        /// <summary>
        /// ������̃A���J�[�ʒu
        /// </summary>
        GcAnchor StringAnchor { get; set; }

        /// <summary>
        /// <see cref="PushStyle"/> �� <see cref="PopStyle"/> �������I�ɌĂяo�����X�R�[�v
        /// </summary>
        StyleScope StyleScope { get; }

        /// <summary>
        /// ������̏c�����v�Z���܂�
        /// </summary>
        /// <param name="str">������</param>
        /// <returns>�c��</returns>
        float CalcStringHeight(in string str);

        /// <summary>
        /// ������̃T�C�Y���v�Z���܂�
        /// </summary>
        /// <param name="str">������</param>
        /// <returns>�T�C�Y</returns>
        float2 CalcStringSize(in string str);

        /// <summary>
        /// ������̉������v�Z���܂�
        /// </summary>
        /// <param name="str">������</param>
        /// <returns>����</returns>
        float CalcStringWidth(in string str);

        /// <summary>
        /// �L�����o�X���W��[���X�N���[�����W�ɕϊ����܂�
        /// </summary>
        /// <param name="canvas">�ϊ��� �L�����o�X���W</param>
        /// <param name="screen">�ϊ��� �[���X�N���[�����W</param>
        void CanvasToScreenPoint(in float2 canvas, out float2 screen);

        /// <summary>
        /// �L�����o�X���W��[���X�N���[�����W�ɕϊ����܂�
        /// </summary>
        /// <param name="canvas">�ϊ��� �L�����o�X���W</param>
        /// <param name="screen">�ϊ��� �[���X�N���[�����W</param>
        void CanvasToScreenPoint(in float2 canvas, out int2 screen);

        /// <summary>
        /// �L�����o�X�O�̑т̐F��ύX���܂�
        /// </summary>
        /// <remarks>
        /// �����L�����o�X�̕`����e�͑S�Ĕj������܂�
        /// </remarks>
        /// <param name="color">�V�����т̐F</param>
        void ChangeBorderColor(in Color color);

        /// <summary>
        /// �L�����o�X�𑜓x��ύX���܂�
        /// </summary>
        /// <remarks>
        /// - �����l�� 720x1280 �ł�<br />
        /// - �f�B�X�v���C�𑜓x�Əc���䂪�قȂ�ꍇ�́A�㉺�������͍��E�ɑт����܂�<br />
        /// - �����L�����o�X�̕`����e�͑S�Ĕj������܂�
        /// </remarks>
        /// <param name="size">�V�����L�����o�X�𑜓x</param>
        void ChangeCanvasSize(in int2 size);

        /// <summary>
        /// <see cref="CurrentCoordinate"/> �����Z�b�g���܂�
        /// </summary>
        void ClearCoordinate();

        /// <summary>
        /// �L�����o�X�� <see cref="BackgroundColor"/> �œh��Ԃ��܂�
        /// </summary>
        void ClearScreen();

        /// <summary>
        /// <see cref="CurrentStyle"/> �����Z�b�g���܂�
        /// </summary>
        void ClearStyle();

        /// <summary>
        /// �������̉~��`�悵�܂�
        /// </summary>
        void DrawCircle();

        /// <summary>
        /// �������̉~��`�悵�܂�
        /// </summary>
        /// <param name="circle">�~</param>
        void DrawCircle(in GcCircle circle);

        /// <summary>
        /// �摜��`�悵�܂�
        /// </summary>
        /// <param name="image">�`�悷��摜</param>
        void DrawImage(in GcImage image);

        /// <summary>
        /// �摜��`�悵�܂�
        /// </summary>
        /// <param name="image">�`�悷��摜</param>
        /// <param name="position">�ʒu</param>
        /// <param name="degree">��]�i�x���@�j</param>
        void DrawImage(in GcImage image, in float2 position, float degree = 0f);

        /// <summary>
        /// �摜���g�k���ĕ`�悵�܂�
        /// </summary>
        /// <param name="image">�`�悷��摜</param>
        /// <param name="rect">�摜���t�B�b�e�B���O�����`�̈�</param>
        void DrawImage(in GcImage image, in GcRect rect);

        /// <summary>
        /// ����`�悵�܂�
        /// </summary>
        void DrawLine();

        /// <summary>
        /// ����`�悵�܂�
        /// </summary>
        /// <param name="line">��</param>
        void DrawLine(in GcLine line);

        /// <summary>
        /// ��`����ŕ`�悵�܂�
        /// </summary>
        void DrawRect();

        /// <summary>
        /// ��`����ŕ`�悵�܂�
        /// </summary>
        /// <param name="rect">��`</param>
        void DrawRect(in GcRect rect);

        /// <summary>
        /// �������`�悵�܂�
        /// </summary>
        /// <param name="str">�`�悷�镶����</param>
        void DrawString(in string str);

        /// <summary>
        /// �������`�悵�܂�
        /// </summary>
        /// <param name="str">�`�悷�镶����</param>
        /// <param name="position">�ʒu</param>
        /// <param name="degree">��]�i�x���@�j</param>
        void DrawString(in string str, in float2 position, float degree = 0f);

        /// <summary>
        /// ��������g�k���ĕ`�悵�܂�
        /// </summary>
        /// <param name="str">�`�悷�镶����</param>
        /// <param name="rect">��������t�B�b�e�B���O�����`�̈�</param>
        void DrawString(in string str, in GcRect rect);

        /// <summary>
        /// �e�N�X�`���[��`�悵�܂�
        /// </summary>
        /// <param name="texture">�`�悷��e�N�X�`���[</param>
        void DrawTexture(in Texture texture);

        /// <summary>
        /// �e�N�X�`���[��`�悵�܂�
        /// </summary>
        /// <param name="texture">�`�悷��e�N�X�`���[</param>
        /// <param name="position">�ʒu</param>
        /// <param name="degree">��]�i�x���@�j</param>
        void DrawTexture(in Texture texture, in float2 position, float degree = 0f);

        /// <summary>
        /// �e�N�X�`���[���g�k���ĕ`�悵�܂�
        /// </summary>
        /// <param name="texture">�`�悷��e�N�X�`���[</param>
        /// <param name="rect">�e�N�X�`���[���t�B�b�e�B���O�����`�̈�</param>
        void DrawTexture(in Texture texture, in GcRect rect);

        /// <summary>
        /// �~��h��ŕ`�悵�܂�
        /// </summary>
        void FillCircle();

        /// <summary>
        /// �~��h��ŕ`�悵�܂�
        /// </summary>
        /// <param name="circle">�~</param>
        void FillCircle(in GcCircle circle);

        /// <summary>
        /// ��`��h��ŕ`�悵�܂�
        /// </summary>
        void FillRect();

        /// <summary>
        /// ��`��h��ŕ`�悵�܂�
        /// </summary>
        /// <param name="rect">��`</param>
        void FillRect(in GcRect rect);

        /// <summary>
        /// �X�^�b�N������W�n�i�ϊ��s��j�����o�� <see cref="CurrentCoordinate"/> �ɏ㏑�����܂�
        /// </summary>
        void PopCoordinate();

        /// <summary>
        /// �X�^�b�N����`��X�^�C�������o�� <see cref="CurrentStyle"/> �ɏ㏑�����܂�
        /// </summary>
        void PopStyle();

        /// <summary>
        /// <see cref="CurrentCoordinate"/> ���X�^�b�N�ɕۑ����܂�
        /// </summary>
        void PushCoordinate();

        /// <summary>
        /// <see cref="CurrentStyle"/> ���X�^�b�N�ɕۑ����܂�
        /// </summary>
        void PushStyle();

        /// <summary>
        /// ���W�n�i�ϊ��s��j����]�����܂�
        /// </summary>
        /// <param name="degree">��]�ʁi�x���@�j</param>
        void RotateCoordinate(in float degree);

        /// <summary>
        /// ���W�n�i�ϊ��s��j���w�肵�����W�𒆐S�ɉ�]�����܂�
        /// </summary>
        /// <param name="degree">��]�ʁi�x���@�j</param>
        /// <param name="origin">��]���S</param>
        void RotateCoordinate(in float degree, in float2 origin);

        /// <summary>
        /// ���W�n�i�ϊ��s��j���g�k�����܂�
        /// </summary>
        /// <param name="scaling">�g�k��</param>
        void ScaleCoordinate(in float2 scaling);

        /// <summary>
        /// �[���X�N���[�����W���L�����o�X���W�ɕϊ����܂�
        /// </summary>
        /// <param name="screen">�ϊ��� �[���X�N���[�����W</param>
        /// <param name="canvas">�ϊ��� �L�����o�X���W</param>
        void ScreenToCanvasPoint(in float2 screen, out float2 canvas);

        /// <summary>
        /// �[���X�N���[�����W���L�����o�X���W�ɕϊ����܂�
        /// </summary>
        /// <param name="screen">�ϊ��� �[���X�N���[�����W</param>
        /// <param name="canvas">�ϊ��� �L�����o�X���W</param>
        void ScreenToCanvasPoint(in float2 screen, out int2 canvas);

        /// <summary>
        /// ���W�n�i�ϊ��s��j�𕽍s�ړ������܂�
        /// </summary>
        /// <param name="translation">�ړ���</param>
        void TranslateCoordinate(in float2 translation);
    }

    public interface IGraphicsEx : IGraphics
    {
        /// <summary>
        /// �L�����o�X��AABB
        /// </summary>
        GcAABB CanvasAABB { get; }

        /// <summary>
        /// �L�����o�X�̒��S���W
        /// </summary>
        float2 CanvasCenter { get; }

        /// <summary>
        /// �L�����o�X�̏c��
        /// </summary>
        int CanvasHeight { get; }

        /// <summary>
        /// �L�����o�X�̉𑜓x�ƃ��t���b�V�����[�g
        /// </summary>
        GcResolution CanvasResolution { get; }

        /// <summary>
        /// �L�����o�X�̉���
        /// </summary>
        int CanvasWidth { get; }

        /// <summary>
        /// ���F
        /// </summary>
        Color ColorAqua { get; }

        /// <summary>
        /// ���F
        /// </summary>
        Color ColorBlack { get; }

        /// <summary>
        /// �F
        /// </summary>
        Color ColorBlue { get; }

        /// <summary>
        /// �V�A��
        /// </summary>
        Color ColorCyan { get; }

        /// <summary>
        /// �D�F
        /// </summary>
        Color ColorGray { get; }

        /// <summary>
        /// �ΐF
        /// </summary>
        Color ColorGreen { get; }

        /// <summary>
        /// ���F
        /// </summary>
        Color ColorPurple { get; }

        /// <summary>
        /// �ԐF
        /// </summary>
        Color ColorRed { get; }

        /// <summary>
        /// ���F
        /// </summary>
        Color ColorWhite { get; }

        /// <summary>
        /// ���F
        /// </summary>
        Color ColorYellow { get; }

        /// <summary>
        /// �[���X�N���[���̏c��
        /// </summary>
        int DeviceScreenHeight { get; }

        /// <summary>
        /// �[���X�N���[���̉���
        /// </summary>
        int DeviceScreenWidth { get; }

        /// <summary>
        /// �т̐F��ύX���܂�
        /// </summary>
        /// <param name="r">�т̐F�̐Ԑ���</param>
        /// <param name="g">�т̐F�̗ΐ���</param>
        /// <param name="b">�т̐F�̐���</param>
        void ChangeBorderColor(in float r, in float g, in float b);

        /// <summary>
        /// �L�����o�X�𑜓x���w�肵�܂�
        /// </summary>
        /// <remarks>
        /// - �����l�� 720x1280 �ł�<br />
        /// - �f�B�X�v���C�𑜓x�Əc���䂪�قȂ�ꍇ�́A�㉺�������͍��E�ɑт����܂�
        /// </remarks>
        /// <param name="width">����</param>
        /// <param name="height">�c��</param>
        void ChangeCanvasSize(in int width, in int height);

        [System.Obsolete("Use to `DrawRect`  instead.")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        void DrawCenterRect(in float2 center, in float2 size, float degree = 0f);

        [System.Obsolete("Use to `DrawString`  instead.")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        void DrawCenterString(in string str, in float x, in float y, float degree = 0f);

        /// <summary>
        /// �~����ŕ`�悵�܂�
        /// </summary>
        /// <param name="x">���S��X���W</param>
        /// <param name="y">���S��Y���W</param>
        /// <param name="radius">���a</param>
        void DrawCircle(in float x, in float y, in float radius);

        /// <summary>
        /// �~����ŕ`�悵�܂�
        /// </summary>
        /// <param name="position">���S�̍��W</param>
        /// <param name="radius">���a</param>
        void DrawCircle(in float2 position, in float radius);

        /// <summary>
        /// �摜��`�悵�܂�
        /// </summary>
        /// <param name="image">�`�悷��摜</param>
        /// <param name="x">X���W</param>
        /// <param name="y">Y���W</param>
        /// <param name="degree">��]�i�x���@�j</param>
        void DrawImage(in GcImage image, in float x, in float y, float degree = 0f);

        /// <summary>
        /// �摜���g�k���ĕ`�悵�܂�
        /// </summary>
        /// <param name="image">�`�悷��摜</param>
        /// <param name="x">X���W</param>
        /// <param name="y">Y���W</param>
        /// <param name="width">�����B�摜�̉���������ɂȂ�悤�Ɋg�k�����</param>
        /// <param name="height">�c���B�摜�̏c��������ɂȂ�悤�Ɋg�k�����</param>
        /// <param name="degree">��]�i�x���@�j</param>
        void DrawImage(in GcImage image, in float x, in float y, in float width, in float height, float degree = 0f);

        /// <summary>
        /// ����`�悵�܂�
        /// </summary>
        /// <param name="begin">�n�_</param>
        /// <param name="end">�I�_</param>
        void DrawLine(in float2 begin, in float2 end);

        /// <summary>
        /// ����`�悵�܂�
        /// </summary>
        /// <param name="x0">�n�_��X���W</param>
        /// <param name="y0">�n�_��Y���W</param>
        /// <param name="x1">�I�_��X���W</param>
        /// <param name="y1">�I�_��Y���W</param>
        void DrawLine(in float x0, in float y0, in float x1, in float y1);

        /// <summary>
        /// ��`����ŕ`�悵�܂�
        /// </summary>
        /// <param name="x">X���W</param>
        /// <param name="y">Y���W</param>
        /// <param name="width">����</param>
        /// <param name="height">�c��</param>
        /// <param name="degree">��]�i�x���@�j</param>
        void DrawRect(in float x, in float y, in float width, in float height, float degree = 0f);

        /// <summary>
        /// ��`����ŕ`�悵�܂�
        /// </summary>
        /// <param name="position">�ʒu</param>
        /// <param name="size">�傫��</param>
        /// <param name="degree">��]�i�x���@�j</param>
        void DrawRect(in float2 position, in float2 size, float degree = 0f);

        [System.Obsolete("Use to `DrawString`  instead.")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        void DrawRightString(in string str, in float x, in float y, float degree = 0f);

        /// <summary>
        /// �������`�悵�܂�
        /// </summary>
        /// <param name="str">�`�悷�镶����</param>
        /// <param name="x">X���W</param>
        /// <param name="y">Y���W</param>
        /// <param name="degree">��]�i�x���@�j</param>
        void DrawString(in string str, in float x, in float y, float degree = 0f);

        /// <summary>
        /// ��������g�k���ĕ`�悵�܂�
        /// </summary>
        /// <param name="str">�`�悷�镶����</param>
        /// <param name="x">X���W</param>
        /// <param name="y">Y���W</param>
        /// <param name="width">�����B������̉���������ɂȂ�悤�Ɋg�k�����</param>
        /// <param name="height">�c���B������̏c��������ɂȂ�悤�Ɋg�k�����</param>
        /// <param name="degree">��]�i�x���@�j</param>
        void DrawString(in string str, in float x, in float y, in float width, in float height, float degree = 0f);

        /// <summary>
        /// �e�N�X�`���[���g�k���ĕ`�悵�܂�
        /// </summary>
        /// <param name="texture">�`�悷��e�N�X�`���[</param>
        /// <param name="x">X���W</param>
        /// <param name="y">Y���W</param>
        /// <param name="width">�����B�摜�̉���������ɂȂ�悤�Ɋg�k�����</param>
        /// <param name="height">�c���B�摜�̏c��������ɂȂ�悤�Ɋg�k�����</param>
        /// <param name="degree">��]�i�x���@�j</param>
        void DrawTexture(in Texture texture, in float x, in float y, in float width, in float height, float degree = 0f);

        [System.Obsolete("Use to `FillRect`  instead.")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        void FillCenterRect(in float2 center, in float2 size, float degree = 0f);

        /// <summary>
        /// �~��h��ŕ`�悵�܂�
        /// </summary>
        /// <param name="x">���S��X���W</param>
        /// <param name="y">���S��Y���W</param>
        /// <param name="radius">���a</param>
        void FillCircle(in float x, in float y, in float radius);

        /// <summary>
        /// �~��h��ŕ`�悵�܂�
        /// </summary>
        /// <param name="position">���S�̍��W</param>
        /// <param name="radius">���a</param>
        void FillCircle(in float2 position, in float radius);

        /// <summary>
        /// ��`��h��ŕ`�悵�܂�
        /// </summary>
        /// <param name="x">X���W</param>
        /// <param name="y">Y���W</param>
        /// <param name="width">����</param>
        /// <param name="height">�c��</param>
        /// <param name="degree">��]�i�x���@�j</param>
        void FillRect(in float x, in float y, in float width, in float height, float degree = 0f);

        /// <summary>
        /// ��`��h��ŕ`�悵�܂�
        /// </summary>
        /// <param name="position">�ʒu</param>
        /// <param name="size">�傫��</param>
        /// <param name="degree">��]�i�x���@�j</param>
        void FillRect(in float2 position, in float2 size, float degree = 0f);

        /// <summary>
        /// �摜�̏c�����擾���܂�
        /// </summary>
        /// <param name="image">�摜</param>
        /// <returns>�c��</returns>
        int GetImageHeight(in GcImage image);

        /// <summary>
        /// �摜�̃T�C�Y���擾���܂�
        /// </summary>
        /// <param name="image">�摜</param>
        /// <returns>�T�C�Y</returns>
        int2 GetImageSize(in GcImage image);

        /// <summary>
        /// �摜�̉������擾���܂�
        /// </summary>
        /// <param name="image">�摜</param>
        /// <returns>����</returns>
        int GetImageWidth(in GcImage image);

        /// <summary>
        /// ���W�n�i�ϊ��s��j����]�����܂�
        /// </summary>
        /// <param name="degree">��]�ʁi�x���@�j</param>
        /// <param name="originX">��]���S��X���W</param>
        /// <param name="originY">��]���S��Y���W</param>
        void RotateCoordinate(in float degree, in float originX, in float originY);

        /// <summary>
        /// ���W�n�i�ϊ��s��j���g�k�����܂�
        /// </summary>
        /// <param name="sx">X�������̊g�k��</param>
        /// <param name="sy">Y�������̊g�k��</param>
        void ScaleCoordinate(in float sx, in float sy);

        /// <summary>
        /// �w�i�F���w�肵�܂�
        /// </summary>
        /// <param name="color">�w�i�F</param>
        void SetBackgroundColor(in Color color);

        /// <summary>
        /// �w�i�F���w�肵�܂�
        /// </summary>
        /// <param name="r">�w�i�F�̐Ԑ���</param>
        /// <param name="g">�w�i�F�̗ΐ���</param>
        /// <param name="b">�w�i�F�̐���</param>
        void SetBackgroundColor(in float r, in float g, in float b);

        /// <summary>
        /// �`��F���w�肵�܂�
        /// </summary>
        /// <param name="r">�`��F�̐Ԑ���</param>
        /// <param name="g">�`��F�̗ΐ���</param>
        /// <param name="b">�`��F�̐���</param>
        /// <param name="a">�`��F�̕s�����x</param>
        void SetColor(in float r, in float g, in float b, float a = 1f);

        /// <summary>
        /// �`��F���w�肵�܂�
        /// </summary>
        /// <param name="r">�`��F�̐Ԑ���</param>
        /// <param name="g">�`��F�̗ΐ���</param>
        /// <param name="b">�`��F�̐���</param>
        /// <param name="a">�`��F�̕s�����x</param>
        void SetColor(in byte r, in byte g, in byte b, byte a = 255);

        /// <summary>
        /// �`��F���w�肵�܂�
        /// </summary>
        /// <param name="color">�`��F</param>
        void SetColor(in Color color);

        /// <summary>
        /// �`��F���w�肵�܂�
        /// </summary>
        /// <param name="color">�`��F</param>
        /// <param name="alpha">�`��F�̕s�����x</param>
        void SetColor(in Color color, in float alpha);

        /// <summary>
        /// �t�H���g���w�肵�܂�
        /// </summary>
        /// <param name="font">�t�H���g</param>
        void SetFont(in GcFont font);

        /// <summary>
        /// �t�H���g�T�C�Y���w�肵�܂�
        /// </summary>
        /// <param name="fontSize">�t�H���g�T�C�Y</param>
        void SetFontSize(in int fontSize);

        /// <summary>
        /// �`���̒[�_�̌`����w�肵�܂�
        /// </summary>
        /// <param name="lineCap">�`���̒[�_�̌`��</param>
        void SetLineCap(in GcLineCap lineCap);

        /// <summary>
        /// �`���̑������w�肵�܂�
        /// </summary>
        /// <param name="lineWidth">�`���̑���</param>
        void SetLineWidth(in float lineWidth);

        /// <summary>
        /// ���W�n�i�ϊ��s��j���w�肵�܂�
        /// </summary>
        /// <param name="matrix">���W�n�i�ϊ��s��j</param>
        void SetCoordinate(in float2x3 matrix);

        /// <summary>
        /// ��`��摜�̃A���J�[�ʒu���w�肵�܂�
        /// </summary>
        /// <param name="anchor">�A���J�[�ʒu</param>
        void SetRectAnchor(in GcAnchor anchor);

        [System.Obsolete("Use to `ChangeCanvasSize`  instead.")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        void SetResolution(in int width, in int height);

        /// <summary>
        /// ������̃A���J�[�ʒu���w�肵�܂�
        /// </summary>
        /// <param name="anchor">�A���J�[�ʒu</param>
        void SetStringAnchor(in GcAnchor anchor);

        /// <summary>
        /// �X�^�C�����w�肵�܂�
        /// </summary>
        /// <param name="style"></param>
        void SetStyle(in GcStyle style);

        /// <summary>
        /// ���W�n�i�ϊ��s��j�𕽍s�ړ������܂�
        /// </summary>
        /// <param name="tx">X�������̈ړ���</param>
        /// <param name="ty">Y�������̈ړ���</param>
        void TranslateCoordinate(in float tx, in float ty);
    }
}
